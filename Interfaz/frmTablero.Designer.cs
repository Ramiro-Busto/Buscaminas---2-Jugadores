namespace Interfaz
{
    partial class frmTablero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTablero = new System.Windows.Forms.Panel();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnFinalizarPartida = new System.Windows.Forms.Button();
            this.lblAciertosJugador2 = new System.Windows.Forms.Label();
            this.lblAciertosJugador1 = new System.Windows.Forms.Label();
            this.lblCaptionPuntajes = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.lblTitulo.Location = new System.Drawing.Point(330, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(226, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscaminas";
            //
            // panelTablero
            //
            this.panelTablero.BackColor = System.Drawing.Color.White;
            this.panelTablero.Location = new System.Drawing.Point(40, 100);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.Size = new System.Drawing.Size(540, 540);
            this.panelTablero.TabIndex = 1;
            //
            // grpInfo
            //
            this.grpInfo.Controls.Add(this.btnFinalizarPartida);
            this.grpInfo.Controls.Add(this.lblAciertosJugador2);
            this.grpInfo.Controls.Add(this.lblAciertosJugador1);
            this.grpInfo.Controls.Add(this.lblCaptionPuntajes);
            this.grpInfo.Controls.Add(this.lblTurno);
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.grpInfo.Location = new System.Drawing.Point(600, 100);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(340, 540);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Partida en curso";
            //
            // btnFinalizarPartida
            //
            this.btnFinalizarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnFinalizarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPartida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarPartida.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarPartida.Location = new System.Drawing.Point(20, 440);
            this.btnFinalizarPartida.Name = "btnFinalizarPartida";
            this.btnFinalizarPartida.Size = new System.Drawing.Size(300, 55);
            this.btnFinalizarPartida.TabIndex = 4;
            this.btnFinalizarPartida.Text = "Finalizar Partida";
            this.btnFinalizarPartida.UseVisualStyleBackColor = false;
            this.btnFinalizarPartida.Click += new System.EventHandler(this.btnFinalizarPartida_Click);
            //
            // lblAciertosJugador2
            //
            this.lblAciertosJugador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblAciertosJugador2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAciertosJugador2.ForeColor = System.Drawing.Color.White;
            this.lblAciertosJugador2.Location = new System.Drawing.Point(20, 260);
            this.lblAciertosJugador2.Name = "lblAciertosJugador2";
            this.lblAciertosJugador2.Size = new System.Drawing.Size(300, 70);
            this.lblAciertosJugador2.TabIndex = 3;
            this.lblAciertosJugador2.Text = "label2";
            this.lblAciertosJugador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblAciertosJugador1
            //
            this.lblAciertosJugador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.lblAciertosJugador1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAciertosJugador1.ForeColor = System.Drawing.Color.White;
            this.lblAciertosJugador1.Location = new System.Drawing.Point(20, 180);
            this.lblAciertosJugador1.Name = "lblAciertosJugador1";
            this.lblAciertosJugador1.Size = new System.Drawing.Size(300, 70);
            this.lblAciertosJugador1.TabIndex = 2;
            this.lblAciertosJugador1.Text = "label1";
            this.lblAciertosJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblCaptionPuntajes
            //
            this.lblCaptionPuntajes.AutoSize = true;
            this.lblCaptionPuntajes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCaptionPuntajes.Location = new System.Drawing.Point(20, 145);
            this.lblCaptionPuntajes.Name = "lblCaptionPuntajes";
            this.lblCaptionPuntajes.Size = new System.Drawing.Size(97, 25);
            this.lblCaptionPuntajes.TabIndex = 1;
            this.lblCaptionPuntajes.Text = "Puntajes";
            //
            // lblTurno
            //
            this.lblTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.lblTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurno.ForeColor = System.Drawing.Color.White;
            this.lblTurno.Location = new System.Drawing.Point(20, 30);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(300, 70);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "label1";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // frmTablero
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.panelTablero);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTablero_FormClosing);
            this.Load += new System.EventHandler(this.frmTablero_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelTablero;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnFinalizarPartida;
        private System.Windows.Forms.Label lblAciertosJugador2;
        private System.Windows.Forms.Label lblAciertosJugador1;
        private System.Windows.Forms.Label lblCaptionPuntajes;
        private System.Windows.Forms.Label lblTurno;
    }
}