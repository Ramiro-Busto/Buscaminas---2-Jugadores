using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string contraseña;
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }

        private DateTime fechaRegistro;
        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public override string ToString()
        {
            return $"{this.nombre}";
        }
    }
}
