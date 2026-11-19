using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using BE;

namespace Interfaz
{
    public partial class frmTablero : Form
    {
        private static readonly Color colorJugador1 = Color.FromArgb(70, 130, 200);
        private static readonly Color colorJugador2 = Color.FromArgb(210, 120, 40);

        private Sesion sesion = new Sesion();
        private BLL_Buscaminas bllBuscaminas = new BLL_Buscaminas();
        private Partida partidaActual;
        private UC_Celda[,] controlesCelda = new UC_Celda[10, 10];
        private bool partidaFinalizada = false;

        public frmTablero()
        {
            InitializeComponent();
        }

        private Usuario jugador1;
        private Usuario jugador2;

        private void frmTablero_Load(object sender, EventArgs e)
        {
            jugador1 = sesion.ObtenerJugador1();
            jugador2 = sesion.ObtenerJugador2();

            bllBuscaminas.IniciarJuego(jugador1, jugador2);

            BLL_Partida bllPartida = new BLL_Partida();
            partidaActual = bllPartida.IniciarPartida(jugador1.ID, jugador2.ID);

            CrearTableroVisual();
            ActualizarTurno();
            ActualizarPuntajes();
        }

        private void ActualizarPuntajes()
        {
            lblAciertosJugador1.Text = jugador1.Nombre + ": " + bllBuscaminas.AciertosJugador1 + " aciertos";
            lblAciertosJugador2.Text = jugador2.Nombre + ": " + bllBuscaminas.AciertosJugador2 + " aciertos";
        }

        private void CrearTableroVisual()
        {
            panelTablero.Controls.Clear();

            int tamañoCelda = 54;

            foreach (Celda celda in bllBuscaminas.Tablero.Celdas)
            {
                UC_Celda ucCelda = new UC_Celda();
                ucCelda.Celda = celda;
                ucCelda.Width = tamañoCelda;
                ucCelda.Height = tamañoCelda;
                ucCelda.Left = celda.Columna * tamañoCelda;
                ucCelda.Top = celda.Fila * tamañoCelda;
                ucCelda.SeleccionarCelda += UcCelda_SeleccionarCelda;
                ucCelda.Actualizar();

                controlesCelda[celda.Fila, celda.Columna] = ucCelda;
                panelTablero.Controls.Add(ucCelda);
            }
        }

        private void UcCelda_SeleccionarCelda(UC_Celda control)
        {
            Celda celda = control.Celda;

            Usuario jugadorQueJuega = bllBuscaminas.JugadorActual;

            bool fueMina = bllBuscaminas.Jugar(celda.Fila, celda.Columna);

            string resultado;
            if (fueMina)
            {
                resultado = "Mina";
            }
            else
            {
                resultado = "Vacio";
            }

            BLL_MovimientoXml bllMovimientoXml = new BLL_MovimientoXml();
            bllMovimientoXml.RegistrarMovimiento(partidaActual.ID, celda.Fila, celda.Columna, resultado, jugadorQueJuega.Nombre);

            RefrescarTableroVisual();
            ActualizarTurno();
            ActualizarPuntajes();

            if (bllBuscaminas.TableroCompleto())
            {
                FinalizarPartida();
            }
        }

        private void RefrescarTableroVisual()
        {
            foreach (Celda celda in bllBuscaminas.Tablero.Celdas)
            {
                controlesCelda[celda.Fila, celda.Columna].Actualizar();
            }
        }

        private void ActualizarTurno()
        {
            lblTurno.Text = "Turno de: " + bllBuscaminas.JugadorActual.Nombre;

            if (bllBuscaminas.JugadorActual == jugador1)
            {
                lblTurno.BackColor = colorJugador1;
            }
            else
            {
                lblTurno.BackColor = colorJugador2;
            }
        }

        private void btnFinalizarPartida_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que querés finalizar la partida ahora?", "Finalizar partida", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                FinalizarPartida();
            }
        }

        private void frmTablero_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!partidaFinalizada && partidaActual != null)
            {
                BLL_Partida bllPartida = new BLL_Partida();
                bllPartida.CancelarPartida(partidaActual);
            }
        }

        private void FinalizarPartida()
        {
            partidaFinalizada = true;

            Usuario ganador = bllBuscaminas.ObtenerGanador();

            int? idGanador = null;
            if (ganador != null)
            {
                idGanador = ganador.ID;
            }

            BLL_Partida bllPartida = new BLL_Partida();
            bllPartida.FinalizarPartida(partidaActual, idGanador);

            string mensaje;
            if (ganador != null)
            {
                mensaje = "Ganó " + ganador.Nombre;
            }
            else
            {
                mensaje = "Empate";
            }

            MessageBox.Show("Partida finalizada. " + mensaje, "Fin de la partida");

            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}