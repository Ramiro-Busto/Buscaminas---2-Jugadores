using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Estadistica
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private int partidasGanadas;
        public int PartidasGanadas
        {
            get { return partidasGanadas; }
            set { partidasGanadas = value; }
        }

        private int partidasPerdidas;
        public int PartidasPerdidas
        {
            get { return partidasPerdidas; }
            set { partidasPerdidas = value; }
        }

        private int partidasEmpatadas;
        public int PartidasEmpatadas
        {
            get { return partidasEmpatadas; }
            set { partidasEmpatadas = value; }
        }

        private double promedioVictorias;
        public double PromedioVictorias
        {
            get { return promedioVictorias; }
            set { promedioVictorias = value; }
        }

        private int tiempoTotalJugado;
        public int TiempoTotalJugado
        {
            get { return tiempoTotalJugado; }
            set { tiempoTotalJugado = value; }
        }
    }
}
