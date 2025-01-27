using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.Repositorio
{
    internal class LinksJSON
    {

        private static readonly string COMIENZO_LINKS = "http://localhost:8080/api/";
        //private static readonly string COMIENZO_LINKS = "http://localhost:8080/api/";

        //DELETE
        public static readonly string ELIMINAR_USUARIO = COMIENZO_LINKS + "eliminarusuario";
        public static readonly string ELIMINAR_INCIDENCIA = COMIENZO_LINKS + "eliminarincidencia";

        //PATCH
        public static readonly string MODIFICAR_USUARIO = COMIENZO_LINKS + "modificarusuario";
        public static readonly string MODIFICAR_INCIDENCIA = COMIENZO_LINKS + "modificarincidencia";

        //POST
        public static readonly string LOGIN = COMIENZO_LINKS + "login";
        public static readonly string CREAR_USUARIO = COMIENZO_LINKS + "crearusuario";
        public static readonly string CREAR_INCIDENCIA = COMIENZO_LINKS + "crearincidencia";

        //GET
        public static readonly string INCIDENCIAS = COMIENZO_LINKS + "incidencias";
        public static readonly string SOURCES = COMIENZO_LINKS + "sources";
        public static readonly string USUARIOS = COMIENZO_LINKS + "usuarios";
    }
}
