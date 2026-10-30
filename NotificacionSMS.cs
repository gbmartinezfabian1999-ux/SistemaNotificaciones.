using System;

namespace SistemaNotificaciones
{
    public class NotificacionSMS : Notificacion, IProgramable
    {
        public NotificacionSMS(
            string destinatario,
            string mensaje,
            string prioridad)
            : base(destinatario, mensaje, prioridad)
        {
            if (mensaje.Length > 160)
            {
                throw new ArgumentException(
                    "El SMS no puede superar los 160 caracteres.");
            }
        }

        public override void Enviar()
        {
            Console.WriteLine("Enviando SMS...");
            Console.WriteLine("Destinatario: " + Destinatario);
            Console.WriteLine("Mensaje: " + Mensaje);

            Estado = "Enviada";

            Console.WriteLine("SMS enviado correctamente.");
        }

        public void Programar(DateTime fecha)
        {
            Console.WriteLine("SMS programado para: " + fecha);
        }
    }
}
