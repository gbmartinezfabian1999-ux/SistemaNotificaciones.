using System;

namespace SistemaNotificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorNotificaciones gestor = new GestorNotificaciones();

            NotificacionSMS sms = new NotificacionSMS(
                "8091234567",
                "Hola, este es un mensaje SMS.",
                "Alta"
            );

            NotificacionCorreo correo = new NotificacionCorreo(
                "usuario@gmail.com",
                "Bienvenido a nuestro sistema.",
                "Normal"
            );

            NotificacionWhatsApp whatsapp = new NotificacionWhatsApp(
                "8291234567",
                "Tu pedido está listo.",
                "Crítica"
            );

            sms.Programar(DateTime.Now.AddHours(2));

            whatsapp.Registrar();

            gestor.Agregar(sms);
            gestor.Agregar(correo);
            gestor.Agregar(whatsapp);

            Console.WriteLine("=== SISTEMA DE NOTIFICACIONES ===");

            gestor.EnviarTodas();

            whatsapp.ConfirmarEntrega();

            Console.WriteLine("\n=== INFORMACIÓN FINAL ===");

            gestor.MostrarTodas();

            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}