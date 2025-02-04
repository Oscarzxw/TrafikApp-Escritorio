using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class PostJSON
    {
        

        public static async Task<Usuario> obtenerUsuarioLogin(string email, string contrasena)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Usuario usuarioLogin = new Usuario
                    {
                        id = 0,
                        nombre = "",
                        apellido = "",
                        email = email,
                        contrasena = contrasena,
                        rol = ""
                    };

                    string json = JsonConvert.SerializeObject(usuarioLogin);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(LinksJSON.LOGIN, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Usuario usuario = JsonConvert.DeserializeObject<Usuario>(responseBody);

                        return usuario;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Excepción: {ex.Message}");
                    return null;
                }
            }
        }


        public static async Task<bool> crearUsuario(Usuario usuario)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonConvert.SerializeObject(usuario);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(LinksJSON.CREAR_USUARIO, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Usuario usuarioCreado = JsonConvert.DeserializeObject<Usuario>(responseBody);

                        Console.WriteLine("Usuario creado exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al crear usuario: {response.StatusCode}");
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

        public static async Task<bool> crearIncidencia(Incidencia incidencia)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var datosAEnviar = new
                    {
                        sourceId = incidencia.sourceId,
                        incidenceType = incidencia.incidenceType,
                        autonomousRegion = incidencia.autonomousRegion,
                        province = incidencia.province,
                        cause = incidencia.cause,
                        cityTown = incidencia.cityTown,
                        startDate = incidencia.startDate,
                        road = incidencia.road,
                        latitude = incidencia.latitude,
                        longitude = incidencia.longitude
                    };

                    string json = JsonConvert.SerializeObject(datosAEnviar);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(LinksJSON.CREAR_INCIDENCIA, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        Incidencia incidenciaCreada = JsonConvert.DeserializeObject<Incidencia>(responseBody);

                        Console.WriteLine("Incidencia creada exitosamente.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine($"Error al crear incidencia: {response.StatusCode}");
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
