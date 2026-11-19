using System;
using DAL;
using BE;

namespace BLL
{
    public class BLL_Bitacora
    {
        private void Registrar(string tipo, string descripcion, int idUsuario)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.Tipo = tipo;
            bitacora.Descripcion = descripcion;
            bitacora.Fecha = DateTime.Now;
            bitacora.Usuario = new Usuario();
            bitacora.Usuario.ID = idUsuario;

            MP_Bitacora mpBitacora = new MP_Bitacora();
            mpBitacora.Agregar(bitacora);
        }

        public void RegistrarLogin(int idUsuario)
        {
            Registrar("Login", "Inicio de sesión", idUsuario);
        }

        public void RegistrarLogout(int idUsuario)
        {
            Registrar("Logout", "Cierre de sesión", idUsuario);
        }

        public void RegistrarInicioPartida(int idUsuario)
        {
            Registrar("InicioPartida", "Inicio de partida", idUsuario);
        }

        public void RegistrarFinPartida(int idUsuario)
        {
            Registrar("FinPartida", "Fin de partida", idUsuario);
        }
    }
}