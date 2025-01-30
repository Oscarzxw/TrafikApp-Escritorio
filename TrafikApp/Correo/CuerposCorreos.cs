using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafikApp.Model;

namespace TrafikApp.Correo
{
    internal class CuerposCorreos
    {

        public static string mensajeBienvenida(string nombre, string apellido, string rol)
        {
            string style = $@"<style>
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
        </style>";
            string mensajePersonalizado;
            if (rol.Equals("admin", StringComparison.OrdinalIgnoreCase))
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
                {style}
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

            return mensajeBody;
        }


        public static string mensajeDespedida(string nombre, string apellido)
        {
            string style = $@"<style>
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
                background-color: #FF0000;
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
        </style>";
            string mensajeBody = $@"
            <!DOCTYPE html>
            <html lang='es'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Mensaje de TrafikApp</title>
                {style}
            </head>
            <body>
                <div class='email-container'>
                    <div class='header'>
                        <h1>¡Sentimos que te vayas!</h1>
                    </div>
                    <div class='content'>
                        <p>Hola <span class='highlight'>{nombre} {apellido}</span>,</p>
                        <p>Tu cuenta ha sido eliminada de TrafikApp!</p>
                        <p>Si tienes alguna queja o necesitas ayuda, no dudes en contactarnos.</p>
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

            return mensajeBody;
        }

    }
}
