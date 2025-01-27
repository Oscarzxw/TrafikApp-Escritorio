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
        

        public static async Task<List<Incidencia>> recogerIncidencias()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                   
                    string contenidoJSON = await client.GetStringAsync(LinksJSON.INCIDENCIAS);

                    
                    List<Incidencia> listaIncidencias = JsonConvert.DeserializeObject<List<Incidencia>>(contenidoJSON);

                    
                    return listaIncidencias;
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
                    string contenidoJSON = await client.GetStringAsync(LinksJSON.SOURCES);

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
                    string contenidoJSON = await client.GetStringAsync(LinksJSON.USUARIOS);

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
