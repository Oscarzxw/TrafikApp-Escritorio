using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class DeleteJSON
    {
        
        public static async Task<bool> eliminarUsuario(Usuario usuario)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(usuario);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(LinksJSON.ELIMINAR_USUARIO),
                        Content = content
                    });

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Usuario eliminado exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al eliminar usuario: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return false;
                }
            }
        }

        public static async Task<bool> eliminarIncidencia(string incidenciaId)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Incidencia incidencia = new Incidencia(incidenciaId);


                    string json = JsonConvert.SerializeObject(incidencia);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.SendAsync(new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(LinksJSON.ELIMINAR_INCIDENCIA),
                        Content = content
                    });

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Incidencia eliminada exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al eliminar incidencia: {response.StatusCode}");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return false;
                }
            }
        }

    }
}
