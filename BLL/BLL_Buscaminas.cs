using System;
using BE;

namespace BLL
{
    public class BLL_Buscaminas
    {
        private Tablero tablero;
        private Usuario jugador1;
        private Usuario jugador2;
        private Usuario jugadorActual;
        private int aciertosJugador1;
        private int aciertosJugador2;

        public Tablero Tablero
        {
            get { return tablero; }
        }

        public Usuario JugadorActual
        {
            get { return jugadorActual; }
        }

        public int AciertosJugador1
        {
            get { return aciertosJugador1; }
        }

        public int AciertosJugador2
        {
            get { return aciertosJugador2; }
        }
        public void IniciarJuego(Usuario j1, Usuario j2)
        {
            BLL_Tablero bllTablero = new BLL_Tablero();
            tablero = bllTablero.CrearTablero();

            jugador1 = j1;
            jugador2 = j2;
            jugadorActual = j1;

            aciertosJugador1 = 0;
            aciertosJugador2 = 0;
        }

        public bool Jugar(int fila, int columna)
        {
            BLL_Tablero bllTablero = new BLL_Tablero();
            bool fueMina = bllTablero.DestaparCelda(tablero, fila, columna);

            if (fueMina)
            {
                if (jugadorActual == jugador1)
                {
                    aciertosJugador1++;
                }
                else
                {
                    aciertosJugador2++;
                }
            }

            CambiarTurno();

            return fueMina;
        }

        private void CambiarTurno()
        {
            if (jugadorActual == jugador1)
            {
                jugadorActual = jugador2;
            }
            else
            {
                jugadorActual = jugador1;
            }
        }

        public bool TableroCompleto()
        {
            BLL_Tablero bllTablero = new BLL_Tablero();
            return bllTablero.TableroCompleto(tablero);
        }

        public Usuario ObtenerGanador()
        {
            if (aciertosJugador1 > aciertosJugador2)
            {
                return jugador1;
            }
            else if (aciertosJugador2 > aciertosJugador1)
            {
                return jugador2;
            }
            else
            {
                return null;
            }
        }
    }
}