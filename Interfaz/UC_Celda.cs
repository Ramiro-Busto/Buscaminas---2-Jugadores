using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BE;

namespace Interfaz
{
    public partial class UC_Celda : UserControl
    {
        private static Image imagenCeldaTapada;
        private static Image imagenMina;

        static UC_Celda()
        {
            string carpetaRecursos = Path.Combine(Application.StartupPath, "Recursos");
            imagenCeldaTapada = Image.FromFile(Path.Combine(carpetaRecursos, "celda_tapada.png"));
            imagenMina = Image.FromFile(Path.Combine(carpetaRecursos, "mina.png"));
        }

        public event delSeleccionarCelda SeleccionarCelda;

        private Celda celda;
        public Celda Celda
        {
            get { return celda; }
            set { celda = value; }
        }

        public UC_Celda()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            if (celda.Destapada)
            {
                btnCelda.Enabled = false;
                btnCelda.BackgroundImageLayout = ImageLayout.Stretch;

                if (celda.TieneMina)
                {
                    btnCelda.BackgroundImage = imagenMina;
                    btnCelda.Text = "";
                }
                else
                {
                    btnCelda.BackgroundImage = null;
                    btnCelda.BackColor = Color.FromArgb(235, 242, 250);

                    if (celda.MinasVecinas == 0)
                    {
                        btnCelda.Text = "";
                    }
                    else
                    {
                        btnCelda.Text = celda.MinasVecinas.ToString();
                        btnCelda.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                        btnCelda.ForeColor = ObtenerColorNumero(celda.MinasVecinas);
                    }
                }
            }
            else
            {
                btnCelda.BackgroundImageLayout = ImageLayout.Stretch;
                btnCelda.BackgroundImage = imagenCeldaTapada;
                btnCelda.Text = "";
            }
        }

        private Color ObtenerColorNumero(int numero)
        {
            Color color;

            if (numero == 1)
            {
                color = Color.FromArgb(0, 0, 230);
            }
            else if (numero == 2)
            {
                color = Color.FromArgb(0, 140, 0);
            }
            else if (numero == 3)
            {
                color = Color.FromArgb(210, 0, 0);
            }
            else if (numero == 4)
            {
                color = Color.FromArgb(100, 0, 150);
            }
            else if (numero == 5)
            {
                color = Color.FromArgb(120, 0, 0);
            }
            else if (numero == 6)
            {
                color = Color.FromArgb(0, 150, 150);
            }
            else if (numero == 7)
            {
                color = Color.Black;
            }
            else
            {
                color = Color.FromArgb(100, 100, 100);
            }

            return color;
        }

        private void btnCelda_Click(object sender, EventArgs e)
        {
            SeleccionarCelda(this);
        }
    }
}