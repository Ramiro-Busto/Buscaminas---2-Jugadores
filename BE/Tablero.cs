using System;
using System.Collections.Generic;

namespace BE
{
    public class Tablero
    {
        private int filas;
        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }

        private int columnas;
        public int Columnas
        {
            get { return columnas; }
            set { columnas = value; }
        }

        private List<Celda> celdas = new List<Celda>();
        public List<Celda> Celdas
        {
            get { return celdas; }
        }

        public Tablero(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Celda celda = new Celda();
                    celda.Fila = f;
                    celda.Columna = c;
                    celdas.Add(celda);
                }
            }
        }
    }
}