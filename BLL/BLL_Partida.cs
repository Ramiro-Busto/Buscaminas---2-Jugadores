using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Partida
    {
        public Partida IniciarPartida(int idJugador1, int idJugador2)
        {
            Partida partida = new Partida();
            partida.Jugador1 = new Usuario();
            partida.Jugador1.ID = idJugador1;
            partida.Jugador2 = new Usuario();
            partida.Jugador2.ID = idJugador2;
            partida.FechaInicio = DateTime.Now;
            partida.Estado = "Jugando";

            MP_Partida mpPartida = new MP_Partida();
            mpPartida.Agregar(partida);

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarInicioPartida(idJugador1);
            bllBitacora.RegistrarInicioPartida(idJugador2);

            return partida;
        }

        public void FinalizarPartida(Partida partida, int? idGanador)
        {
            partida.FechaFin = DateTime.Now;
            partida.Estado = "Finalizada";
            partida.DuracionSegundos = (int)(partida.FechaFin.Value - partida.FechaInicio).TotalSeconds;

            if (idGanador == null)
            {
                partida.Ganador = null;
            }
            else
            {
                partida.Ganador = new Usuario();
                partida.Ganador.ID = idGanador.Value;
            }

            MP_Partida mpPartida = new MP_Partida();
            mpPartida.Modificar(partida);

            BLL_Estadistica bllEstadistica = new BLL_Estadistica();
            BLL_Bitacora bllBitacora = new BLL_Bitacora();

            if (idGanador == null)
            {
                bllEstadistica.ActualizarPorResultado(partida.Jugador1.ID, "Empatada");
                bllEstadistica.ActualizarPorResultado(partida.Jugador2.ID, "Empatada");
            }
            else if (idGanador == partida.Jugador1.ID)
            {
                bllEstadistica.ActualizarPorResultado(partida.Jugador1.ID, "Ganada");
                bllEstadistica.ActualizarPorResultado(partida.Jugador2.ID, "Perdida");
            }
            else
            {
                bllEstadistica.ActualizarPorResultado(partida.Jugador2.ID, "Ganada");
                bllEstadistica.ActualizarPorResultado(partida.Jugador1.ID, "Perdida");
            }

            bllBitacora.RegistrarFinPartida(partida.Jugador1.ID);
            bllBitacora.RegistrarFinPartida(partida.Jugador2.ID);
        }

        public void CancelarPartida(Partida partida)
        {
            MP_Partida mpPartida = new MP_Partida();
            mpPartida.Borrar(partida);
        }

        public int ObtenerTiempoTotalJugado(int idUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.ID = idUsuario;

            MP_Partida mpPartida = new MP_Partida();
            return mpPartida.ObtenerTiempoTotal(usuario);
        }

        public List<Partida> ListarParaHistorial()
        {
            MP_Partida mpPartida = new MP_Partida();
            return mpPartida.ListarParaHistorial();
        }
    }
}