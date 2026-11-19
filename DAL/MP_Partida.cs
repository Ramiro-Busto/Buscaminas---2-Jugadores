using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Partida : IMapper<Partida>
    {
        public void Agregar(Partida obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@IdJugador1", obj.Jugador1.ID));
            p.Add(a.CrearParametro("@IdJugador2", obj.Jugador2.ID));
            p.Add(a.CrearParametro("@FechaInicio", obj.FechaInicio));

            DataTable dt = a.Leer("sp_AltaPartida", p);
            obj.ID = Convert.ToInt32(dt.Rows[0]["NuevoID"]);

            a.Cerrar();
        }

        public void Borrar(Partida obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@ID", obj.ID));

            a.Escribir("sp_BorrarPartida", p);

            a.Cerrar();
        }

        public void Modificar(Partida obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@ID", obj.ID));
            p.Add(a.CrearParametro("@FechaFin", obj.FechaFin.Value));
            p.Add(a.CrearParametro("@DuracionSegundos", obj.DuracionSegundos));

            SqlParameter pGanador = new SqlParameter("@IdGanador", SqlDbType.Int);
            pGanador.Value = (obj.Ganador != null) ? (object)obj.Ganador.ID : DBNull.Value;
            p.Add(pGanador);

            a.Escribir("sp_FinalizarPartida", p);

            a.Cerrar();
        }

        public List<Partida> Listar()
        {
            throw new NotImplementedException();
        }

        public int ObtenerTiempoTotal(Usuario usuario)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@IdUsuario", usuario.ID));

            DataTable dt = a.Leer("sp_ObtenerTiempoTotalJugado", p);

            int total = 0;
            foreach (DataRow row in dt.Rows)
            {
                total = Convert.ToInt32(row["TotalSegundos"]);
            }

            a.Cerrar();
            return total;
        }

        public List<Partida> ListarParaHistorial()
        {
            Acceso a = new Acceso();
            a.Abrir();

            DataTable tabla = a.Leer("sp_ListarPartidas");

            List<Partida> partidas = new List<Partida>();

            foreach (DataRow fila in tabla.Rows)
            {
                Partida partida = new Partida();
                partida.ID = Convert.ToInt32(fila["ID"]);

                Usuario jugador1 = new Usuario();
                jugador1.Nombre = Convert.ToString(fila["Jugador1"]);
                partida.Jugador1 = jugador1;

                Usuario jugador2 = new Usuario();
                jugador2.Nombre = Convert.ToString(fila["Jugador2"]);
                partida.Jugador2 = jugador2;

                partida.FechaInicio = Convert.ToDateTime(fila["FechaInicio"]);

                if (fila["FechaFin"] == DBNull.Value)
                {
                    partida.FechaFin = null;
                }
                else
                {
                    partida.FechaFin = Convert.ToDateTime(fila["FechaFin"]);
                }

                partida.Estado = Convert.ToString(fila["Estado"]);

                if (fila["DuracionSegundos"] == DBNull.Value)
                {
                    partida.DuracionSegundos = 0;
                }
                else
                {
                    partida.DuracionSegundos = Convert.ToInt32(fila["DuracionSegundos"]);
                }

                if (fila["Ganador"] == DBNull.Value)
                {
                    Usuario ganador = new Usuario();
                    ganador.Nombre = "Empate";
                    partida.Ganador = ganador;
                }
                else
                {
                    Usuario ganador = new Usuario();
                    ganador.Nombre = Convert.ToString(fila["Ganador"]);
                    partida.Ganador = ganador;
                }

                partidas.Add(partida);
            }

            a.Cerrar();
            return partidas;
        }
    }
}