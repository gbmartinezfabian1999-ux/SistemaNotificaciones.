using System;
namespace SistemaNotificaciones
{
    public class NotificacionCorreo : Notificacion
    {
        public NotificacionCorreo(
            string destinatario,
            string mensaje,
            string prioridad)
            : base(destinatario, mensaje, prioridad)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine("Enviando correo electrónico...");
            Console.WriteLine("Destinatario: " + Destinatario);
            Console.WriteLine("Mensaje: " + Mensaje);

            Estado = "Enviada";

            Console.WriteLine("Correo enviado correctamente.");
        }
    }
}