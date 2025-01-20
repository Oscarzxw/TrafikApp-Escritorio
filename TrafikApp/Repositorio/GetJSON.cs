using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class GetJSON
    {
        private static readonly string INCIDENCIAS = "http://localhost:8080/api/incidencias";
        private static readonly string SOURCES = "http://localhost:8080/api/sources";
        private static readonly string USUARIOS = "http://localhost:8080/api/usuarios";

        public static async Task<ArrayList> recogerIncidencias()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                   
                    string contenidoJSON = await client.GetStringAsync(INCIDENCIAS);

                    
                    List<Incidencia> listaIncidencias = JsonConvert.DeserializeObject<List<Incidencia>>(contenidoJSON);

                    
                    return new ArrayList(listaIncidencias);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener o procesar el JSON desde la URL: {ex.Message}");
                }
            }
        }

        public static async Task<ArrayList> recogerSources()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string contenidoJSON = await client.GetStringAsync(SOURCES);

                    List<Source> listaIncidencias = JsonConvert.DeserializeObject<List<Source>>(contenidoJSON);

                    return new ArrayList(listaIncidencias);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener o procesar el JSON desde la URL: {ex.Message}");
                }
            }
        }

        public static async Task<ArrayList> recogerUsuarios()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string contenidoJSON = await client.GetStringAsync(USUARIOS);

                    List<Usuario> listaIncidencias = JsonConvert.DeserializeObject<List<Usuario>>(contenidoJSON);

                    return new ArrayList(listaIncidencias);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al obtener o procesar el JSON desde la URL: {ex.Message}");
                }
            }
        }
    }
}
