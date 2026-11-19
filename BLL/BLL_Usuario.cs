using System;
using System.Collections.Generic;
using DAL;
using BE;

namespace BLL
{
    public class BLL_Usuario
    {
        public void Registrar(Usuario usuario)
        {
            usuario.FechaRegistro = DateTime.Now;

            MP_Usuario mpUsuario = new MP_Usuario();
            mpUsuario.Agregar(usuario);

            Usuario usuarioCreado = mpUsuario.ValidarLogin(usuario.Nombre, usuario.Contraseña);

            Estadistica estadistica = new Estadistica();
            estadistica.Usuario = usuarioCreado;

            MP_Estadistica mpEstadistica = new MP_Estadistica();
            mpEstadistica.Agregar(estadistica);
        }

        public Usuario Login(string nombre, string contraseña)
        {
            List<Usuario> usuarios = Listar();

            Usuario usuarioEncontrado = null;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre.ToLower() == nombre.ToLower())
                {
                    usuarioEncontrado = usuario;
                }
            }

            if (usuarioEncontrado == null)
            {
                return null;
            }

            if (usuarioEncontrado.Contraseña != contraseña)
            {
                return null;
            }

            return usuarioEncontrado;
        }

        public List<Usuario> Listar()
        {
            MP_Usuario mpUsuario = new MP_Usuario();
            return mpUsuario.Listar();
        }

        public bool ExisteUsuario(string nombre)
        {
            List<Usuario> usuarios = Listar();

            bool existe = false;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nombre.ToLower() == nombre.ToLower())
                {
                    existe = true;
                }
            }

            return existe;
        }
    }
}