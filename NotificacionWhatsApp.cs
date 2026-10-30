using System;

namespace SistemaNotificaciones
{
    public class NotificacionWhatsApp : Notificacion, IRegistrable, IConfirmable
    {
        public NotificacionWhatsApp(
            string destinatario,
            string mensaje,
            string prioridad)
            : base(destinatario, mensaje, prioridad)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine("Enviando mensaje por WhatsApp...");
            Console.WriteLine("Destinatario: " + Destinatario);
            Console.WriteLine("Mensaje: " + Mensaje);

            Estado = "Enviada";

            Console.WriteLine("WhatsApp enviado correctamente.");
        }

        public void Registrar()
        {
            Console.WriteLine("Notificación de WhatsApp registrada.");
        }

        public void ConfirmarEntrega()
        {
            Estado = "Entregada";
            Console.WriteLine("Entrega de WhatsApp confirmada.");
        }
    }
}