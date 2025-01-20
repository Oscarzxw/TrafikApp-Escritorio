using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.Model
{
    internal class Usuario
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string contrasena { get; set; }
        public string rol {  get; set; }

        public Usuario(string nombre, string apellido, string email, string contrasena, string rol)
        {
            this.id = 0;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        public Usuario()
        {
        }

        public Usuario(int id, string nombre, string apellido, string email, string contrasena, string rol)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.contrasena = contrasena;
            this.rol = rol;
        }
    }
}
