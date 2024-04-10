using System;
using System.ServiceModel;
using System.Collections.Generic;


namespace IServicioReservasNamespace
{
    [ServiceContract]
    public interface IServicioReservas
    {
        [OperationContract]
        Reserva CrearReserva(string cliente, DateTime fecha, int duracion);
        [OperationContract]
        Reserva ObtenerReserva(int idReserva);
        [OperationContract]
        bool CancelarReserva(int idReserva);
        [OperationContract]
        List<Reserva> VerTodasReservas();
    }
}