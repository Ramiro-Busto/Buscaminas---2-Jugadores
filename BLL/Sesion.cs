using BE;

namespace BLL
{
    public class Sesion
    {
        private static Usuario jugador1;
        private static Usuario jugador2;

        public void AgregarJugador1(Usuario usuario)
        {
            jugador1 = usuario;
        }

        public void AgregarJugador2(Usuario usuario)
        {
            jugador2 = usuario;
        }

        public void Eliminar(Usuario usuario)
        {
            if (jugador1 == usuario)
            {
                jugador1 = null;
            }

            if (jugador2 == usuario)
            {
                jugador2 = null;
            }
        }

        public Usuario ObtenerJugador1()
        {
            return jugador1;
        }

        public Usuario ObtenerJugador2()
        {
            return jugador2;
        }
    }
}