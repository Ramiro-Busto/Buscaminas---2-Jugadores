using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Bitacora : IMapper<Bitacora>
    {
        public void Agregar(Bitacora obj)
        {
            Acceso a = new Acceso();
            a.Abrir();

            List<SqlParameter> p = new List<SqlParameter>();
            p.Add(a.CrearParametro("@Tipo", obj.Tipo));
            p.Add(a.CrearParametro("@Descripcion", obj.Descripcion));
            p.Add(a.CrearParametro("@Fecha", obj.Fecha));
            p.Add(a.CrearParametro("@IdUsuario", obj.Usuario.ID));

            a.Escribir("sp_AltaBitacora", p);

            a.Cerrar();
        }

        public void Borrar(Bitacora obj)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Bitacora obj)
        {
            throw new NotImplementedException();
        }

        public List<Bitacora> Listar()
        {
            throw new NotImplementedException();
        }
    }
}