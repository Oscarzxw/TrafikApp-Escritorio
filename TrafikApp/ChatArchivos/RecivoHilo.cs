using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafikApp.ChatArchivos
{
    internal class RecivoHilo
    {

        private StreamReader reader;
        private Perfil perfil;

        public RecivoHilo(StreamReader reader, Perfil perfil)
        {
            this.reader = reader;
            this.perfil = perfil;
        }

        public void Start()
        {
            Thread hilo = new Thread(RecibirMensajes);
            hilo.Start();
        }

        private void RecibirMensajes()
        {
            try
            {
                string mensaje;
                while ((mensaje = reader.ReadLine()) != null)
                {
                    // Usamos Invoke para actualizar el ListBox en el hilo principal
                    perfil.Invoke(new Action(() => perfil.MostrarMensaje("Servidor: " + mensaje)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //perfil.Invoke(new Action(() => perfil.MostrarMensaje("Error al recibir mensaje: " + ex.Message)));
            }
        }

    }
}
