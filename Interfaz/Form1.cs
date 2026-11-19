using System;
using System.Windows.Forms;
using BLL;
using BE;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        private Sesion sesion = new Sesion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            Usuario jugador1 = sesion.ObtenerJugador1();
            Usuario jugador2 = sesion.ObtenerJugador2();

            bool jugador1Logueado = (jugador1 != null);
            bool jugador2Logueado = (jugador2 != null);

            txtNombre1.Visible = !jugador1Logueado;
            txtContraseña1.Visible = !jugador1Logueado;
            lblUsuarioCaption1.Visible = !jugador1Logueado;
            lblContraseñaCaption1.Visible = !jugador1Logueado;
            btnRegistrarJugador1.Visible = !jugador1Logueado;
            btnLoginJugador1.Visible = !jugador1Logueado;

            lblJugador1.Visible = jugador1Logueado;
            btnLogoutJugador1.Visible = jugador1Logueado;

            txtNombre2.Visible = !jugador2Logueado;
            txtContraseña2.Visible = !jugador2Logueado;
            lblUsuarioCaption2.Visible = !jugador2Logueado;
            lblContraseñaCaption2.Visible = !jugador2Logueado;
            btnRegistrarJugador2.Visible = !jugador2Logueado;
            btnLoginJugador2.Visible = !jugador2Logueado;

            lblJugador2.Visible = jugador2Logueado;
            btnLogoutJugador2.Visible = jugador2Logueado;

            if (jugador1Logueado)
            {
                lblJugador1.Text = jugador1.Nombre;
            }

            if (jugador2Logueado)
            {
                lblJugador2.Text = jugador2.Nombre;
            }

            btnIniciarPartida.Enabled = (jugador1Logueado && jugador2Logueado);
        }

        private void btnLoginJugador1_Click(object sender, EventArgs e)
        {
            if (txtNombre1.Text == "" || txtContraseña1.Text == "")
            {
                MessageBox.Show("Completá usuario y contraseña", "Datos incompletos");
                return;
            }

            BLL_Usuario bllUsuario = new BLL_Usuario();
            Usuario usuario = bllUsuario.Login(txtNombre1.Text, txtContraseña1.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de login");
                return;
            }

            Usuario jugador2Actual = sesion.ObtenerJugador2();
            if (jugador2Actual != null && jugador2Actual.Nombre.ToLower() == usuario.Nombre.ToLower())
            {
                MessageBox.Show("Ese usuario ya está jugando como Jugador 2", "Usuario repetido");
                return;
            }

            sesion.AgregarJugador1(usuario);

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogin(usuario.ID);

            ActualizarPantalla();
        }

        private void btnRegistrarJugador1_Click(object sender, EventArgs e)
        {
            if (txtNombre1.Text == "" || txtContraseña1.Text == "")
            {
                MessageBox.Show("Completá usuario y contraseña", "Datos incompletos");
                return;
            }

            Usuario jugador2Actual = sesion.ObtenerJugador2();
            if (jugador2Actual != null && jugador2Actual.Nombre.ToLower() == txtNombre1.Text.ToLower())
            {
                MessageBox.Show("Ese usuario ya está jugando como Jugador 2", "Usuario repetido");
                return;
            }

            BLL_Usuario bllUsuario = new BLL_Usuario();
            if (bllUsuario.ExisteUsuario(txtNombre1.Text))
            {
                MessageBox.Show("Ese usuario ya existe, elegí otro nombre", "Usuario existente");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre1.Text;
            usuario.Contraseña = txtContraseña1.Text;

            bllUsuario.Registrar(usuario);

            Usuario usuarioLogueado = bllUsuario.Login(usuario.Nombre, usuario.Contraseña);
            sesion.AgregarJugador1(usuarioLogueado);

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogin(usuarioLogueado.ID);

            ActualizarPantalla();
        }

        private void btnLoginJugador2_Click(object sender, EventArgs e)
        {
            if (txtNombre2.Text == "" || txtContraseña2.Text == "")
            {
                MessageBox.Show("Completá usuario y contraseña", "Datos incompletos");
                return;
            }

            BLL_Usuario bllUsuario = new BLL_Usuario();
            Usuario usuario = bllUsuario.Login(txtNombre2.Text, txtContraseña2.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de login");
                return;
            }

            Usuario jugador1Actual = sesion.ObtenerJugador1();
            if (jugador1Actual != null && jugador1Actual.Nombre.ToLower() == usuario.Nombre.ToLower())
            {
                MessageBox.Show("Ese usuario ya está jugando como Jugador 1", "Usuario repetido");
                return;
            }

            sesion.AgregarJugador2(usuario);

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogin(usuario.ID);

            ActualizarPantalla();
        }

        private void btnRegistrarJugador2_Click(object sender, EventArgs e)
        {
            if (txtNombre2.Text == "" || txtContraseña2.Text == "")
            {
                MessageBox.Show("Completá usuario y contraseña", "Datos incompletos");
                return;
            }

            Usuario jugador1Actual = sesion.ObtenerJugador1();
            if (jugador1Actual != null && jugador1Actual.Nombre.ToLower() == txtNombre2.Text.ToLower())
            {
                MessageBox.Show("Ese usuario ya está jugando como Jugador 1", "Usuario repetido");
                return;
            }

            BLL_Usuario bllUsuario = new BLL_Usuario();
            if (bllUsuario.ExisteUsuario(txtNombre2.Text))
            {
                MessageBox.Show("Ese usuario ya existe, elegí otro nombre", "Usuario existente");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre2.Text;
            usuario.Contraseña = txtContraseña2.Text;

            bllUsuario.Registrar(usuario);

            Usuario usuarioLogueado = bllUsuario.Login(usuario.Nombre, usuario.Contraseña);
            sesion.AgregarJugador2(usuarioLogueado);

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogin(usuarioLogueado.ID);

            ActualizarPantalla();
        }

        private void btnLogoutJugador1_Click(object sender, EventArgs e)
        {
            Usuario jugador1 = sesion.ObtenerJugador1();

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogout(jugador1.ID);

            sesion.Eliminar(jugador1);

            txtNombre1.Text = "";
            txtContraseña1.Text = "";

            ActualizarPantalla();
        }

        private void btnLogoutJugador2_Click(object sender, EventArgs e)
        {
            Usuario jugador2 = sesion.ObtenerJugador2();

            BLL_Bitacora bllBitacora = new BLL_Bitacora();
            bllBitacora.RegistrarLogout(jugador2.ID);

            sesion.Eliminar(jugador2);

            txtNombre2.Text = "";
            txtContraseña2.Text = "";

            ActualizarPantalla();
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            frmTablero frmTablero = new frmTablero();
            frmTablero.Show();
            this.Hide();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            frmEstadisticas frmEstadisticas = new frmEstadisticas();
            frmEstadisticas.Show();
        }
    }
}