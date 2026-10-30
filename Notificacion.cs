using System;

namespace SistemaNotificaciones
{
    public abstract class Notificacion
    {
        public string Destinatario { get; set; }
        public string Mensaje { get; set; }
        public string Prioridad { get; set; }

        public string Estado { get; protected set; }

        public Notificacion(string destinatario, string mensaje, string prioridad)
        {
            if (string.IsNullOrWhiteSpace(destinatario))
                throw new ArgumentException("El destinatario no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(mensaje))
                throw new ArgumentException("El mensaje no puede estar vacío.");

            Destinatario = destinatario;
            Mensaje = mensaje;
            Prioridad = prioridad;
            Estado = "Pendiente";
        }

        public abstract void Enviar();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Destinatario: " + Destinatario);
            Console.WriteLine("Mensaje: " + Mensaje);
            Console.WriteLine("Prioridad: " + Prioridad);
            Console.WriteLine("Estado: " + Estado);
        }

        public void MarcarFallida()
        {
            Estado = "Fallida";
        }
    }
}