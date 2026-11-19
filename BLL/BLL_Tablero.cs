using System;
using BE;

namespace BLL
{
    public class BLL_Tablero
    {
        private int cantidadMinas = 16;

        public Tablero CrearTablero()
        {
            Tablero tablero = new Tablero(10, 10);
            GenerarMinas(tablero);
            CalcularMinasVecinas(tablero);
            return tablero;
        }

        private Celda ObtenerCelda(Tablero tablero, int fila, int columna)
        {
            foreach (Celda celda in tablero.Celdas)
            {
                if (celda.Fila == fila && celda.Columna == columna)
                {
                    return celda;
                }
            }
            return null;
        }

        private void GenerarMinas(Tablero tablero)
        {
            Random random = new Random();
            int minasColocadas = 0;

            while (minasColocadas < cantidadMinas)
            {
                int f = random.Next(tablero.Filas);
                int c = random.Next(tablero.Columnas);

                Celda celda = ObtenerCelda(tablero, f, c);

                if (!celda.TieneMina)
                {
                    celda.TieneMina = true;
                    minasColocadas++;
                }
            }
        }

        private void CalcularMinasVecinas(Tablero tablero)
        {
            foreach (Celda celda in tablero.Celdas)
            {
                if (!celda.TieneMina)
                {
                    celda.MinasVecinas = ContarMinasAlrededor(tablero, celda.Fila, celda.Columna);
                }
            }
        }

        private int ContarMinasAlrededor(Tablero tablero, int fila, int columna)
        {
            int contador = 0;

            for (int f = fila - 1; f <= fila + 1; f++)
            {
                for (int c = columna - 1; c <= columna + 1; c++)
                {
                    bool esLaMismaCelda = (f == fila && c == columna);
                    bool estaDentroDelTablero = (f >= 0 && f < tablero.Filas && c >= 0 && c < tablero.Columnas);

                    if (estaDentroDelTablero && !esLaMismaCelda)
                    {
                        Celda vecina = ObtenerCelda(tablero, f, c);
                        if (vecina.TieneMina)
                        {
                            contador++;
                        }
                    }
                }
            }

            return contador;
        }
        public bool DestaparCelda(Tablero tablero, int fila, int columna)
        {
            Celda celda = ObtenerCelda(tablero, fila, columna);

            if (celda.Destapada)
            {
                return false;
            }

            celda.Destapada = true;

            if (celda.TieneMina)
            {
                return true;
            }

            if (celda.MinasVecinas == 0)
            {
                DestaparVecinas(tablero, fila, columna);
            }

            return false;
        }

        private void DestaparVecinas(Tablero tablero, int fila, int columna)
        {
            for (int f = fila - 1; f <= fila + 1; f++)
            {
                for (int c = columna - 1; c <= columna + 1; c++)
                {
                    bool esLaMismaCelda = (f == fila && c == columna);
                    bool estaDentroDelTablero = (f >= 0 && f < tablero.Filas && c >= 0 && c < tablero.Columnas);

                    if (estaDentroDelTablero && !esLaMismaCelda)
                    {
                        Celda vecina = ObtenerCelda(tablero, f, c);

                        if (!vecina.Destapada && !vecina.TieneMina)
                        {
                            vecina.Destapada = true;

                            if (vecina.MinasVecinas == 0)
                            {
                                DestaparVecinas(tablero, f, c);
                            }
                        }
                    }
                }
            }
        }

        public bool TableroCompleto(Tablero tablero)
        {
            foreach (Celda celda in tablero.Celdas)
            {
                if (!celda.Destapada)
                {
                    return false;
                }
            }
            return true;
        }
    }
}