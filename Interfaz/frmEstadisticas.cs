using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL;
using BE;

namespace Interfaz
{
    public partial class frmEstadisticas : Form
    {
        private List<Partida> partidas;

        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            BLL_Partida bllPartida = new BLL_Partida();
            partidas = bllPartida.ListarParaHistorial();

            ArmarGridPartidas();
            MostrarEstadisticasJugadores();
        }

        private void MostrarEstadisticasJugadores()
        {
            BLL_Usuario bllUsuario = new BLL_Usuario();
            List<Usuario> usuarios = bllUsuario.Listar();

            BLL_Estadistica bllEstadistica = new BLL_Estadistica();
            BLL_Partida bllPartida = new BLL_Partida();

            List<Estadistica> listaEstadisticas = new List<Estadistica>();

            foreach (Usuario usuario in usuarios)
            {
                Estadistica estadistica = bllEstadistica.Obtener(usuario.ID);
                estadistica.ID = usuario.ID;
                estadistica.Usuario = usuario;
                estadistica.PromedioVictorias = bllEstadistica.ObtenerPromedioVictorias(usuario.ID);
                estadistica.TiempoTotalJugado = bllPartida.ObtenerTiempoTotalJugado(usuario.ID);
                listaEstadisticas.Add(estadistica);
            }

            dgvJugadores.DataSource = listaEstadisticas;
        }

        private void ArmarGridPartidas()
        {
            dgvPartidas.DataSource = partidas;
        }

        private void dgvPartidas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPartidas.Rows.Count == 0) return;
            Partida partidaSeleccionada = (BE.Partida)dgvPartidas.CurrentRow.DataBoundItem as BE.Partida;
            ArmarGridMovimientos(partidaSeleccionada.ID);
        }

        private void ArmarGridMovimientos(int idPartida)
        {
            BLL_MovimientoXml bllMovimientoXml = new BLL_MovimientoXml();
            DataTable movimientos = bllMovimientoXml.ObtenerMovimientos(idPartida);

            dgvMovimientos.DataSource = movimientos;
        }
    }
}