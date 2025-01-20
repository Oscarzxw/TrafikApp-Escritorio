using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class PatchJSON
    {

        private static readonly string MODIFICAR_USUARIO = "http://localhost:8080/api/modificarusuario";

        public static async Task<bool> modificarUsuario(Usuario usuario)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Convertir el objeto Usuario a JSON
                    string json = JsonConvert.SerializeObject(usuario);

                    // Crear el contenido de la solicitud con el tipo de contenido 'application/json'
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Usamos HttpRequestMessage para enviar la solicitud PATCH
                    var request = new HttpRequestMessage
                    {
                        Method = new HttpMethod("PATCH"),  // Aquí usamos PATCH
                        RequestUri = new Uri(MODIFICAR_USUARIO),  // Cambia esta URL por la correcta de tu API
                        Content = content
                    };

                    // Enviar la solicitud PATCH
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
                    // Manejar cualquier excepción que ocurra durante la solicitud
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
