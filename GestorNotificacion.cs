using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaNotificaciones
{
    public class GestorNotificaciones
    {
        private List<Notificacion> notificaciones =
            new List<Notificacion>();

        public void Agregar(Notificacion notificacion)
        {
            notificaciones.Add(notificacion);
        }

        public void MostrarTodas()
        {
            foreach (Notificacion n in notificaciones)
            {
                n.MostrarInformacion();
                Console.WriteLine("----------------------");
            }
        }

        public void EnviarTodas()
        {
            var ordenadas = notificaciones
                .OrderBy(n => ObtenerOrden(n.Prioridad));

            foreach (Notificacion n in ordenadas)
            {
                try
                {
                    n.Enviar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    n.MarcarFallida();
                }

                Console.WriteLine("----------------------");
            }
        }

        private int ObtenerOrden(string prioridad)
        {
            switch (prioridad.ToLower())
            {
                case "crítica":
                case "critica":
                    return 1;

                case "alta":
                    return 2;

                case "normal":
                    return 3;

                case "baja":
                    return 4;

                default:
                    return 5;
            }
        }
    }
}