using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.ChatArchivos
{
    public class Cliente
    {
        private const string HOST = "10.10.13.160";
        private const int PUERTO = 5000;
        private TcpClient cliente;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;
        private Perfil prefil;
        public string nombreUsuario {  get; set; }
        public string apellidoUsuario { get; set; }

        public Cliente(Perfil prefil)
        {
            this.prefil = prefil;
        }

        // Conectar al servidor
        public void Conectar()
        {
            try
            {
                cliente = new TcpClient(HOST, PUERTO);
                stream = cliente.GetStream();
                reader = new StreamReader(stream, Encoding.ASCII);
                writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };

                // Crear un hilo para escuchar los mensajes del servidor
                ReciboHilo hiloRecibir = new ReciboHilo(reader, prefil);
                hiloRecibir.Start();
            }
            catch (Exception ex)
            {
                prefil.MostrarMensaje("Error al conectarse al servidor: " + ex.Message);
            }
        }

        // Enviar mensaje al servidor
        public void EnviarMensaje(string mensaje)
{
    try
    {
        string mensajeFinal = nombreUsuario + " " + apellidoUsuario + ": " + mensaje;
        writer.WriteLine(mensajeFinal);
        prefil.MostrarMensaje("Tú: " + mensaje);
    }
    catch (Exception ex)
    {
        prefil.MostrarMensaje("Error al enviar mensaje: " + ex.Message);
    }
}

        // Cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            catch (Exception ex)
            {
                prefil.MostrarMensaje("Error al cerrar la conexión: " + ex.Message);
            }
        }

    }
}
