using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafikApp.Model;

namespace TrafikApp.Repositorio
{
    internal class PostJSON
    {
        private static readonly string LOGIN = "http://localhost:8080/api/login";
        private static readonly string CREAR_USUARIO = "http://localhost:8080/api/crearusuario";
        private static readonly string CREAR_INCIDENCIA = "http://localhost:8080/api/crearincidencia";

        public static async Task<Usuario> obtenerUsuarioLogin(string email, string contrasena)
        {
            using (HttpClient client = new HttpClient())
            {

                try
                {
                    // Crear el objeto Usuario con los valores a enviar (en este caso, valores proporcionados por el usuario)
                    Usuario usuarioLogin = new Usuario
                    {
                        id = 0,                    // Asignar el valor de id, generalmente no es necesario para login, pero lo pasamos como lo pide la API
                        nombre = "",                // Nombre vacío
                        apellido = "",              // Apellido vacío
                        email = email, // Email proporcionado
                        contrasena = contrasena,         // Contraseña proporcionada
                        rol = ""                    // Rol vacío
                    };

                    // Convertir el objeto Usuario a formato JSON
                    string json = JsonConvert.SerializeObject(usuarioLogin);

                    // Crear el contenido con el tipo de contenido 'application/json'
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Enviar la solicitud POST con el JSON en el cuerpo
                    HttpResponseMessage response = await client.PostAsync(LOGIN, content);

                    if (response.IsSuccessStatusCode)
                    {
                        // Leer la respuesta del servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Deserializar el JSON de la respuesta en un objeto Usuario
                        Usuario usuario = JsonConvert.DeserializeObject<Usuario>(responseBody);

                        // Devolver el objeto Usuario si el login es exitoso
                        return usuario;
                    }
                    else
                    {
                        // Si la respuesta no es exitosa (por ejemplo, credenciales incorrectas), devolver null
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra durante la solicitud
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
                    // Convertir el objeto Usuario a formato JSON
                    string json = JsonConvert.SerializeObject(usuario);

                    // Crear el contenido con el tipo de contenido 'application/json'
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // Enviar la solicitud POST con el JSON en el cuerpo
                    HttpResponseMessage response = await client.PostAsync(CREAR_USUARIO, content);

                    // Verificar si la respuesta fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Opcional: Leer la respuesta del servidor
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Puedes deserializar la respuesta si es necesario, por ejemplo:
                        Usuario usuarioCreado = JsonConvert.DeserializeObject<Usuario>(responseBody);

                        Console.WriteLine("Usuario creado exitosamente.");
                        return true;
                    }
                    else
                    {
                        // Manejar casos donde el servidor devuelve un error (ej. 400 o 500)
                        Console.WriteLine($"Error al crear usuario: {response.StatusCode}");
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

                    HttpResponseMessage response = await client.PostAsync(CREAR_INCIDENCIA, content);

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
