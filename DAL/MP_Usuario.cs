using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Usuario : IMapper<Usuario>
    {
        public void Agregar(Usuario obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@Nombre", obj.Nombre));
            p.Add(a.CrearParametro("@Contraseña", obj.Contraseña));
            p.Add(a.CrearParametro("@FechaRegistro", obj.FechaRegistro));

            a.Escribir("sp_AltaUsuario", p);

            a.Cerrar();
        }

        public void Borrar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<Usuario> usuarios = new List<Usuario>();
            DataTable dt = a.Leer("sp_ListarUsuarios");

            foreach (DataRow row in dt.Rows)
            {
                Usuario u = new Usuario();
                u.ID = Convert.ToInt32(row["ID"]);
                u.Nombre = Convert.ToString(row["Nombre"]);
                u.Contraseña = Convert.ToString(row["Contraseña"]);
                u.FechaRegistro = Convert.ToDateTime(row["FechaRegistro"]);

                usuarios.Add(u);
            }

            a.Cerrar();
            return usuarios;
        }

        public Usuario ValidarLogin(string nombre, string contraseña)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@Nombre", nombre));
            p.Add(a.CrearParametro("@Contraseña", contraseña));

            DataTable dt = a.Leer("sp_ValidarUsuario", p);

            Usuario u = null;
            foreach (DataRow row in dt.Rows)
            {
                u = new Usuario();
                u.ID = Convert.ToInt32(row["ID"]);
                u.Nombre = Convert.ToString(row["Nombre"]);
                u.Contraseña = Convert.ToString(row["Contraseña"]);
                u.FechaRegistro = Convert.ToDateTime(row["FechaRegistro"]);
            }

            a.Cerrar();
            return u;
        }
    }
}