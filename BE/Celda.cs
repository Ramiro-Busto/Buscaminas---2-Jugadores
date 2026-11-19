using System;

namespace BE
{
    public class Celda
    {
        private int fila;
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        private int columna;
        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }

        private bool tieneMina;
        public bool TieneMina
        {
            get { return tieneMina; }
            set { tieneMina = value; }
        }

        private bool destapada;
        public bool Destapada
        {
            get { return destapada; }
            set { destapada = value; }
        }

        private int minasVecinas;
        public int MinasVecinas
        {
            get { return minasVecinas; }
            set { minasVecinas = value; }
        }
    }
}