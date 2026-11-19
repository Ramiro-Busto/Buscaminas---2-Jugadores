using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Estadistica : IMapper<Estadistica>
    {
        public void Agregar(Estadistica obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@IdUsuario", obj.Usuario.ID));

            a.Escribir("sp_InicializarEstadistica", p);

            a.Cerrar();
        }

        public void Borrar(Estadistica obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Estadistica obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@IdUsuario", obj.Usuario.ID));
            p.Add(a.CrearParametro("@PartidasGanadas", obj.PartidasGanadas));
            p.Add(a.CrearParametro("@PartidasPerdidas", obj.PartidasPerdidas));
            p.Add(a.CrearParametro("@PartidasEmpatadas", obj.PartidasEmpatadas));

            a.Escribir("sp_ModificarEstadistica", p);

            a.Cerrar();
        }

        public List<Estadistica> Listar()
        {
            throw new NotImplementedException();
        }

        public Estadistica Obtener(Usuario usuario)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@IdUsuario", usuario.ID));

            DataTable dt = a.Leer("sp_ObtenerEstadistica", p);

            Estadistica e = new Estadistica();
            e.Usuario = usuario;

            foreach (DataRow row in dt.Rows)
            {
                e.PartidasGanadas = Convert.ToInt32(row["PartidasGanadas"]);
                e.PartidasPerdidas = Convert.ToInt32(row["PartidasPerdidas"]);
                e.PartidasEmpatadas = Convert.ToInt32(row["PartidasEmpatadas"]);
            }

            a.Cerrar();
            return e;
        }
    }
}