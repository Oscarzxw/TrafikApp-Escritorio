using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrafikApp.Repositorio;

namespace TrafikApp.ChatArchivos
{
    public class Cliente
    {
        private readonly string URL = LinksJSON.CHAT_LINK; 
        private ClientWebSocket webSocket;
        private CancellationTokenSource cts;
        private Perfil perfil;
        public string nombreUsuario { get; set; }
        public string apellidoUsuario { get; set; }

        public Cliente(Perfil perfil)
        {
            this.perfil = perfil;
            this.webSocket = new ClientWebSocket();
            this.cts = new CancellationTokenSource();
        }

        public async Task ConectarAsync()
        {
            try
            {
                ReiniciarWebSocket();
                await webSocket.ConnectAsync(new Uri(URL), cts.Token);
                _ = RecibirMensajesAsync();
                perfil.MostrarMensaje("Conectado al servidor de chat");
            }
            catch (Exception ex)
            {
                perfil.MostrarMensaje("Error al conectarse al servidor: " + ex.Message);
            }
        }

        public async Task EnviarMensajeAsync(string mensaje)
        {
            try
            {
                if (webSocket.State != WebSocketState.Open)
                {
                    perfil.MostrarMensaje("No está conectado al servidor");
                    return;
                }

                string mensajeFinal = $"{nombreUsuario} {apellidoUsuario}: {mensaje}";
                byte[] buffer = Encoding.UTF8.GetBytes(mensajeFinal);
                await webSocket.SendAsync(new ArraySegment<byte>(buffer),
                    WebSocketMessageType.Text,
                    true,
                    cts.Token);

                perfil.MostrarMensaje("Tú: " + mensaje);
            }
            catch (Exception ex)
            {
                perfil.MostrarMensaje("Error al enviar mensaje: " + ex.Message);
            }
        }

        private async Task RecibirMensajesAsync()
        {
            byte[] buffer = new byte[1024 * 4];

            try
            {
                while (webSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await webSocket.ReceiveAsync(
                        new ArraySegment<byte>(buffer),
                        cts.Token);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure,
                            string.Empty,
                            CancellationToken.None);
                        return;
                    }
                    else
                    {
                        string mensaje = Encoding.UTF8.GetString(buffer, 0, result.Count);

                        if (!string.IsNullOrEmpty(mensaje))
                        {
                            if (perfil.InvokeRequired)
                            {
                                perfil.Invoke(new Action(() => perfil.MostrarMensaje(mensaje)));
                            }
                            else
                            {
                                perfil.MostrarMensaje(mensaje);
                            }
                        }
                    }
                }
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("WebSocket ya fue cerrado. Terminando la escucha.");
            }
            catch (Exception ex)
            {
                perfil.MostrarMensaje("Error al recibir mensaje: " + ex.Message);
            }
        }


        public async Task CerrarConexionAsync()
        {
            try
            {
                if (webSocket.State == WebSocketState.Open)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure,
                        string.Empty,
                        CancellationToken.None);
                }
                cts.Cancel();
                webSocket.Dispose();
            }
            catch (Exception ex)
            {
                perfil.MostrarMensaje("Error al cerrar la conexión: " + ex.Message);
            }
        }

        private void ReiniciarWebSocket()
        {
            if (webSocket != null)
            {
                webSocket.Dispose();
            }

            webSocket = new ClientWebSocket();
            cts = new CancellationTokenSource();
        }
    }
}