using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikApp.Repositorio
{
    internal class LinksJSON
    {
        private static readonly string COMIENZO_LINKS = "https://junior-cherrita-trafikapp-039b4b86.koyeb.app/api/";
        public static readonly string CHAT_LINK = "ws://junior-cherrita-trafikapp-039b4b86.koyeb.app/chat";
        //private static readonly string COMIENZO_LINKS = "http://10.10.13.157:8080/api/";

        //GET
        public static readonly string INCIDENCIAS = COMIENZO_LINKS + "incidencias";
        public static readonly string SOURCES = COMIENZO_LINKS + "sources";
        public static readonly string USUARIOS = COMIENZO_LINKS + "usuarios";

        //POST
        public static readonly string LOGIN = COMIENZO_LINKS + "login";
        public static readonly string CREAR_USUARIO = COMIENZO_LINKS + "crearusuario";
        public static readonly string CREAR_INCIDENCIA = COMIENZO_LINKS + "crearincidencia";

        //PATCH
        public static readonly string MODIFICAR_USUARIO = COMIENZO_LINKS + "modificarusuario";
        public static readonly string MODIFICAR_INCIDENCIA = COMIENZO_LINKS + "modificarincidencia";

        //DELETE
        public static readonly string ELIMINAR_USUARIO = COMIENZO_LINKS + "eliminarusuario";
        public static readonly string ELIMINAR_INCIDENCIA = COMIENZO_LINKS + "eliminarincidencia";

    }
}
