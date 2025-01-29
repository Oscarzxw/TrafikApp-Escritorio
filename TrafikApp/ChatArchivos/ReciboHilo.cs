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

        // Método que se ejecuta en un hilo separado
        public void Start()
        {
            Thread hilo = new Thread(RecibirMensajes);
            hilo.IsBackground = true;  // Hacer el hilo en segundo plano
            hilo.Start();
        }

        // Método para recibir mensajes
        private void RecibirMensajes()
        {
            try
            {
                Console.WriteLine("Hilo de recepción iniciado"); // Log para ver si se inicia el hilo
                string mensaje;
                while ((mensaje = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        // Log de depuración
                        Console.WriteLine("Mensaje recibido: " + mensaje);

                        // Usamos Invoke para actualizar el ListBox en el hilo principal
                        perfil.Invoke(new Action(() => perfil.MostrarMensaje("Servidor: " + mensaje)));
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
