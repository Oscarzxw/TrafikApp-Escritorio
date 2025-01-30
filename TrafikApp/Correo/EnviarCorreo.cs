using System;
using System.Net.Mail;
using System.Net;

namespace TrafikApp.Correo
{
    internal class EnviarCorreo
    {

        private static string user = "trafikappreto@gmail.com"; // Tu correo electrónico
        private static string pass = "oufl mmcp peie stvf"; // Contraseña de aplicación (Gmail)
        
        public static void enviarCorreo(string mensajeBody, string email)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(user, pass),
                    EnableSsl = true
                };
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(user),
                    Subject = "REGISTRO",
                    Body = mensajeBody,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(email);

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
