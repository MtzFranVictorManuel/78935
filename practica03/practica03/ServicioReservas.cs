using System;
using IServicioReservasNamespace;
using System.Collections.Generic;


namespace ServicioReservasNamespace
{
    public class ServicioReservas : IServicioReservas
    {
        private List<Reserva> reservas = new List<Reserva>();
        private int contadorReservas = 1;
        public Reserva CrearReserva(string cliente, DateTime fecha, int duracion)
        {
            var reserva = new Reserva { Id = contadorReservas++, Cliente = cliente, Fecha = fecha, Duracion = duracion };
            reservas.Add(reserva);
            return reserva;
        }

        public Reserva ObtenerReserva(int idReserva)
        {
            return reservas.Find(reserva => reserva.Id == idReserva);
        }

        public bool CancelarReserva(int idReserva)
        {
            int numReservasEliminadas = reservas.RemoveAll(reserva => reserva.Id == idReserva);
            return numReservasEliminadas > 0;
        }

        public List<Reserva> VerTodasReservas()
        {
            return reservas;
        }
    }
}
