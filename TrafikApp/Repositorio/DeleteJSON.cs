using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class DeleteJSON
    {

        private static readonly string ELIMINAR_USUARIO = "http://localhost:8080/api/eliminarusuario";

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
                        RequestUri = new Uri(ELIMINAR_USUARIO),
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

    }
}
