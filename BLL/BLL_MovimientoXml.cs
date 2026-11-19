using System;
using System.Data;
using System.IO;

namespace BLL
{
    public class BLL_MovimientoXml
    {
        public void RegistrarMovimiento(int idPartida, int fila, int columna, string resultado, string nombreUsuario)
        {
            string ruta = ObtenerRuta(idPartida);

            DataTable tabla = new DataTable("Movimientos");
            tabla.Columns.Add("Fila", typeof(int));
            tabla.Columns.Add("Columna", typeof(int));
            tabla.Columns.Add("Resultado", typeof(string));
            tabla.Columns.Add("Jugador", typeof(string));
            tabla.Columns.Add("Fecha", typeof(DateTime));

            if (File.Exists(ruta))
            {
                tabla.ReadXml(ruta);
            }

            DataRow fila2 = tabla.NewRow();
            fila2["Fila"] = fila;
            fila2["Columna"] = columna;
            fila2["Resultado"] = resultado;
            fila2["Jugador"] = nombreUsuario;
            fila2["Fecha"] = DateTime.Now;
            tabla.Rows.Add(fila2);

            tabla.WriteXml(ruta, System.Data.XmlWriteMode.WriteSchema);
        }
        public DataTable ObtenerMovimientos(int idPartida)
        {
            string ruta = ObtenerRuta(idPartida);

            DataTable tabla = new DataTable("Movimientos");

            if (File.Exists(ruta))
            {
                tabla.ReadXml(ruta);
            }

            return tabla;
        }

        private string ObtenerRuta(int idPartida)
        {
            return "Partida_" + idPartida.ToString() + ".xml";
        }
    }
}