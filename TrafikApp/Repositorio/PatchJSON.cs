using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class PatchJSON
    {

        public static async Task<bool> modificarUsuario(Usuario usuario)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(usuario);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage
                    {
                        Method = new HttpMethod("PATCH"),
                        RequestUri = new Uri(LinksJSON.MODIFICAR_USUARIO),
                        Content = content
                    };

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Usuario actualizado exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al actualizar el usuario: {response.StatusCode}");
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

        public static async Task<bool> modificarIncidencia(Incidencia incidencia)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(incidencia);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage
                    {
                        Method = new HttpMethod("PATCH"),
                        RequestUri = new Uri(LinksJSON.MODIFICAR_INCIDENCIA),
                        Content = content
                    };

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Usuario actualizado exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al actualizar el usuario: {response.StatusCode}");
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
