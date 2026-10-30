using System;

namespace SistemaNotificaciones
{
    public interface IProgramable
    {
        void Programar(DateTime fecha);
    }

    public interface IRegistrable
    {
        void Registrar();
    }

    public interface IConfirmable
    {
        void ConfirmarEntrega();
    }
}
