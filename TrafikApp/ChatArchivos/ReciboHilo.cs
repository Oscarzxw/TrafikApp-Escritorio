using System;
using System.IO;
using System.Threading;

namespace TrafikApp.ChatArchivos
{
    internal class ReciboHilo
    {
        private StreamReader reader;
        private Perfil perfil;

        public ReciboHilo(StreamReader reader, Perfil perfil)
        {
            this.reader = reader;
            this.perfil = perfil;
        }

        public void Start()
        {
            Thread hilo = new Thread(RecibirMensajes);
            hilo.IsBackground = true;
            hilo.Start();
        }

        private void RecibirMensajes()
        {
            try
            {
                string mensaje;
                while ((mensaje = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        Console.WriteLine("Mensaje recibido: " + mensaje);

                        if (perfil.InvokeRequired)
                        {
                            perfil.Invoke(new Action(() => perfil.MostrarMensaje(mensaje)));
                        }
                        else
                        {
                            perfil.MostrarMensaje(mensaje);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mensaje vacío recibido.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recibir mensaje: " + ex.Message);
            }
        }
    }
}
