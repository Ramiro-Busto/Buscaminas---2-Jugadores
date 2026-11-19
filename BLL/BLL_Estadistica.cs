using System;
using DAL;
using BE;

namespace BLL
{
    public class BLL_Estadistica
    {
        public Estadistica Obtener(int idUsuario)
        {
            Usuario usuario = new Usuario();
            usuario.ID = idUsuario;

            MP_Estadistica mpEstadistica = new MP_Estadistica();
            return mpEstadistica.Obtener(usuario);
        }

        public void ActualizarPorResultado(int idUsuario, string resultado)
        {
            Estadistica estadistica = Obtener(idUsuario);

            if (resultado == "Ganada")
            {
                estadistica.PartidasGanadas = estadistica.PartidasGanadas + 1;
            }
            else if (resultado == "Perdida")
            {
                estadistica.PartidasPerdidas = estadistica.PartidasPerdidas + 1;
            }
            else if (resultado == "Empatada")
            {
                estadistica.PartidasEmpatadas = estadistica.PartidasEmpatadas + 1;
            }

            MP_Estadistica mpEstadistica = new MP_Estadistica();
            mpEstadistica.Modificar(estadistica);
        }

        public double ObtenerPromedioVictorias(int idUsuario)
        {
            Estadistica estadistica = Obtener(idUsuario);

            int totalPartidas = estadistica.PartidasGanadas + estadistica.PartidasPerdidas + estadistica.PartidasEmpatadas;

            if (totalPartidas == 0)
            {
                return 0;
            }

            return (estadistica.PartidasGanadas * 100.0) / totalPartidas;
        }
    }
}