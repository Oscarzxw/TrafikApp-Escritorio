using System;
using System.Net.Mail;
using System.Net;
using TrafikApp.Model;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Printing;

namespace TrafikApp.Correo
{
    internal class EnviarCorreo
    {

        private static string user = "trafikappreto@gmail.com"; // Tu correo electrónico
        private static string pass = "oufl mmcp peie stvf"; // Contraseña de aplicación (Gmail)
        
        public static void enviarCorreo(Usuario usuario)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string parentDirectory = Directory.GetParent(baseDirectory).Parent.FullName;
            string projectDirectory = Directory.GetParent(parentDirectory).Parent.FullName;

            string rutaImagenLogo = Path.Combine(projectDirectory, "TrafikApp", "Sources", "TrafikApp.png");
            rutaImagenLogo = "file:///" + rutaImagenLogo;
            

            string nombre = usuario.nombre;
            string apellido = usuario.apellido;
            string rol;
            string mensajePersonalizado;
            if (usuario.rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
            {
                rol = "ADMINISTRADOR";
                mensajePersonalizado = "Ahora puedes gestionar usuarios e incidencias en la aplicación de escritorio de TrafikApp.";
            }
            else
            {
                rol = "USUARIO";
                mensajePersonalizado = "Ahora puedes ver las cámaras e incidencias en la aplicación de móvil de TrafikApp.";
            }

            string mensajeBody = $@"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Mensaje de TrafikApp</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f9f9f9;
                        margin: 0;
                        padding: 0;
                    }}
                    .email-container {{
                        max-width: 600px;
                        margin: 20px auto;
                        background-color: #ffffff;
                        border-radius: 10px;
                        overflow: hidden;
                        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
                        border: 1px solid #ddd;
                        box-sizing: border-box;
                    }}
                    .header {{
                        background-color: #007BFF;
                        color: #ffffff;
                        text-align: center;
                        padding: 20px;
                    }}
                    .header h1 {{
                        margin: 0;
                        font-size: 24px;
                    }}
                    .content {{
                        width: 100%; /* Asegura que el div interno ocupe todo el ancho del contenedor */
                        height: 100%; /* Asegura que el div interno ocupe todo el alto */
                        top: 0;
                        left: 0;
                        padding: 20px; /* Padding para el texto */
                        box-sizing: border-box;
                    }}
                    .content p {{
                        margin: 0 0 15px;
                        line-height: 1.5;
                        color: #333333;
                    }}

                    .content .highlight {{
                        font-weight: bold;
                    }}
                    .footer {{
                        background-color: #f1f1f1;
                        text-align: center;
                        padding: 15px;
                        font-size: 12px;
                        color: #666666;
                    }}
                    .footer a {{
                        color: #007BFF;
                        text-decoration: none;
                    }}
                </style>
            </head>
            <body>
                <div class='email-container'>
                    <div class='header'>
                        <h1>¡Bienvenido a TrafikApp!</h1>
                    </div>
                    <div class='content'>
                        <p>Hola <span class='highlight'>{nombre} {apellido}</span>,</p>
                        <p>¡Tu cuenta de <b>{rol}</b> ha sido creada exitosamente en TrafikApp! {mensajePersonalizado}</p>
                        <p>Si tienes alguna pregunta o necesitas ayuda, no dudes en contactarnos.</p>
                        <p>Atentamente,<br>El equipo de TrafikApp</p>
                    </div>
                    <div class='footer'>
                        <p>© 2025 TrafikApp. Todos los derechos reservados.</p>
                        <p><a href='https://trafikapp.com'>Visítanos</a> | <a href='mailto:trafikappreto@gmail.com'>Contáctanos</a></p>
                    </div>
                </div>
            </body>
            </html>
            ";
            try
            {
                // Configuración del cliente SMTP
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(user, pass), // Usuario y contraseña
                    EnableSsl = true // Usar SSL para la conexión segura
                };
                // Crear el mensaje de correo
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(user), // Remitente
                    Subject = "REGISTRO", // Asunto del correo
                    Body = mensajeBody, // Contenido del correo
                    IsBodyHtml = true // Indicar si el contenido es HTML
                };

                // Agregar destinatarios
                mailMessage.To.Add(usuario.email); // Destinatario

                // Enviar el correo
                smtpClient.Send(mailMessage);

                Console.WriteLine("Correo enviado exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al enviar correo: {ex.Message}");
            }
        }

    }
}
