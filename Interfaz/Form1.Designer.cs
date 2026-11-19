namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpJugador1 = new System.Windows.Forms.GroupBox();
            this.btnLogoutJugador1 = new System.Windows.Forms.Button();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.btnLoginJugador1 = new System.Windows.Forms.Button();
            this.btnRegistrarJugador1 = new System.Windows.Forms.Button();
            this.txtContraseña1 = new System.Windows.Forms.TextBox();
            this.lblContraseñaCaption1 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblUsuarioCaption1 = new System.Windows.Forms.Label();
            this.grpJugador2 = new System.Windows.Forms.GroupBox();
            this.btnLogoutJugador2 = new System.Windows.Forms.Button();
            this.lblJugador2 = new System.Windows.Forms.Label();
            this.btnLoginJugador2 = new System.Windows.Forms.Button();
            this.btnRegistrarJugador2 = new System.Windows.Forms.Button();
            this.txtContraseña2 = new System.Windows.Forms.TextBox();
            this.lblContraseñaCaption2 = new System.Windows.Forms.Label();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.lblUsuarioCaption2 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.grpJugador1.SuspendLayout();
            this.grpJugador2.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.lblTitulo.Location = new System.Drawing.Point(260, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(480, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscaminas - 2 Jugadores";
            //
            // grpJugador1
            //
            this.grpJugador1.Controls.Add(this.btnLogoutJugador1);
            this.grpJugador1.Controls.Add(this.lblJugador1);
            this.grpJugador1.Controls.Add(this.btnLoginJugador1);
            this.grpJugador1.Controls.Add(this.btnRegistrarJugador1);
            this.grpJugador1.Controls.Add(this.txtContraseña1);
            this.grpJugador1.Controls.Add(this.lblContraseñaCaption1);
            this.grpJugador1.Controls.Add(this.txtNombre1);
            this.grpJugador1.Controls.Add(this.lblUsuarioCaption1);
            this.grpJugador1.BackColor = System.Drawing.Color.White;
            this.grpJugador1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpJugador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.grpJugador1.Location = new System.Drawing.Point(50, 110);
            this.grpJugador1.Name = "grpJugador1";
            this.grpJugador1.Size = new System.Drawing.Size(430, 250);
            this.grpJugador1.TabIndex = 1;
            this.grpJugador1.TabStop = false;
            this.grpJugador1.Text = "Jugador 1";
            //
            // btnLogoutJugador1
            //
            this.btnLogoutJugador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLogoutJugador1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutJugador1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutJugador1.ForeColor = System.Drawing.Color.White;
            this.btnLogoutJugador1.Location = new System.Drawing.Point(125, 185);
            this.btnLogoutJugador1.Name = "btnLogoutJugador1";
            this.btnLogoutJugador1.Size = new System.Drawing.Size(180, 48);
            this.btnLogoutJugador1.TabIndex = 7;
            this.btnLogoutJugador1.Text = "Cerrar sesión";
            this.btnLogoutJugador1.UseVisualStyleBackColor = false;
            this.btnLogoutJugador1.Click += new System.EventHandler(this.btnLogoutJugador1_Click);
            //
            // lblJugador1
            //
            this.lblJugador1.AutoSize = true;
            this.lblJugador1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.lblJugador1.Location = new System.Drawing.Point(25, 55);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(100, 25);
            this.lblJugador1.TabIndex = 6;
            this.lblJugador1.Text = "Jugador 1";
            //
            // btnLoginJugador1
            //
            this.btnLoginJugador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnLoginJugador1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginJugador1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginJugador1.ForeColor = System.Drawing.Color.White;
            this.btnLoginJugador1.Location = new System.Drawing.Point(195, 165);
            this.btnLoginJugador1.Name = "btnLoginJugador1";
            this.btnLoginJugador1.Size = new System.Drawing.Size(130, 48);
            this.btnLoginJugador1.TabIndex = 5;
            this.btnLoginJugador1.Text = "Login";
            this.btnLoginJugador1.UseVisualStyleBackColor = false;
            this.btnLoginJugador1.Click += new System.EventHandler(this.btnLoginJugador1_Click);
            //
            // btnRegistrarJugador1
            //
            this.btnRegistrarJugador1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarJugador1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarJugador1.Location = new System.Drawing.Point(25, 165);
            this.btnRegistrarJugador1.Name = "btnRegistrarJugador1";
            this.btnRegistrarJugador1.Size = new System.Drawing.Size(160, 48);
            this.btnRegistrarJugador1.TabIndex = 4;
            this.btnRegistrarJugador1.Text = "Registrarse";
            this.btnRegistrarJugador1.UseVisualStyleBackColor = true;
            this.btnRegistrarJugador1.Click += new System.EventHandler(this.btnRegistrarJugador1_Click);
            //
            // txtContraseña1
            //
            this.txtContraseña1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña1.Location = new System.Drawing.Point(165, 100);
            this.txtContraseña1.Name = "txtContraseña1";
            this.txtContraseña1.PasswordChar = '●';
            this.txtContraseña1.Size = new System.Drawing.Size(240, 32);
            this.txtContraseña1.TabIndex = 3;
            //
            // lblContraseñaCaption1
            //
            this.lblContraseñaCaption1.AutoSize = true;
            this.lblContraseñaCaption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseñaCaption1.ForeColor = System.Drawing.Color.Black;
            this.lblContraseñaCaption1.Location = new System.Drawing.Point(25, 103);
            this.lblContraseñaCaption1.Name = "lblContraseñaCaption1";
            this.lblContraseñaCaption1.Size = new System.Drawing.Size(115, 28);
            this.lblContraseñaCaption1.TabIndex = 2;
            this.lblContraseñaCaption1.Text = "Contraseña:";
            //
            // txtNombre1
            //
            this.txtNombre1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre1.Location = new System.Drawing.Point(165, 45);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(240, 32);
            this.txtNombre1.TabIndex = 1;
            //
            // lblUsuarioCaption1
            //
            this.lblUsuarioCaption1.AutoSize = true;
            this.lblUsuarioCaption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioCaption1.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioCaption1.Location = new System.Drawing.Point(25, 48);
            this.lblUsuarioCaption1.Name = "lblUsuarioCaption1";
            this.lblUsuarioCaption1.Size = new System.Drawing.Size(85, 28);
            this.lblUsuarioCaption1.TabIndex = 0;
            this.lblUsuarioCaption1.Text = "Usuario:";
            //
            // grpJugador2
            //
            this.grpJugador2.Controls.Add(this.btnLogoutJugador2);
            this.grpJugador2.Controls.Add(this.lblJugador2);
            this.grpJugador2.Controls.Add(this.btnLoginJugador2);
            this.grpJugador2.Controls.Add(this.btnRegistrarJugador2);
            this.grpJugador2.Controls.Add(this.txtContraseña2);
            this.grpJugador2.Controls.Add(this.lblContraseñaCaption2);
            this.grpJugador2.Controls.Add(this.txtNombre2);
            this.grpJugador2.Controls.Add(this.lblUsuarioCaption2);
            this.grpJugador2.BackColor = System.Drawing.Color.White;
            this.grpJugador2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpJugador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.grpJugador2.Location = new System.Drawing.Point(530, 110);
            this.grpJugador2.Name = "grpJugador2";
            this.grpJugador2.Size = new System.Drawing.Size(430, 250);
            this.grpJugador2.TabIndex = 2;
            this.grpJugador2.TabStop = false;
            this.grpJugador2.Text = "Jugador 2";
            //
            // btnLogoutJugador2
            //
            this.btnLogoutJugador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLogoutJugador2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutJugador2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutJugador2.ForeColor = System.Drawing.Color.White;
            this.btnLogoutJugador2.Location = new System.Drawing.Point(125, 185);
            this.btnLogoutJugador2.Name = "btnLogoutJugador2";
            this.btnLogoutJugador2.Size = new System.Drawing.Size(180, 48);
            this.btnLogoutJugador2.TabIndex = 7;
            this.btnLogoutJugador2.Text = "Cerrar sesión";
            this.btnLogoutJugador2.UseVisualStyleBackColor = false;
            this.btnLogoutJugador2.Click += new System.EventHandler(this.btnLogoutJugador2_Click);
            //
            // lblJugador2
            //
            this.lblJugador2.AutoSize = true;
            this.lblJugador2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.lblJugador2.Location = new System.Drawing.Point(25, 55);
            this.lblJugador2.Name = "lblJugador2";
            this.lblJugador2.Size = new System.Drawing.Size(100, 25);
            this.lblJugador2.TabIndex = 6;
            this.lblJugador2.Text = "Jugador 2";
            //
            // btnLoginJugador2
            //
            this.btnLoginJugador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnLoginJugador2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginJugador2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoginJugador2.ForeColor = System.Drawing.Color.White;
            this.btnLoginJugador2.Location = new System.Drawing.Point(195, 165);
            this.btnLoginJugador2.Name = "btnLoginJugador2";
            this.btnLoginJugador2.Size = new System.Drawing.Size(130, 48);
            this.btnLoginJugador2.TabIndex = 5;
            this.btnLoginJugador2.Text = "Login";
            this.btnLoginJugador2.UseVisualStyleBackColor = false;
            this.btnLoginJugador2.Click += new System.EventHandler(this.btnLoginJugador2_Click);
            //
            // btnRegistrarJugador2
            //
            this.btnRegistrarJugador2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarJugador2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarJugador2.Location = new System.Drawing.Point(25, 165);
            this.btnRegistrarJugador2.Name = "btnRegistrarJugador2";
            this.btnRegistrarJugador2.Size = new System.Drawing.Size(160, 48);
            this.btnRegistrarJugador2.TabIndex = 4;
            this.btnRegistrarJugador2.Text = "Registrarse";
            this.btnRegistrarJugador2.UseVisualStyleBackColor = true;
            this.btnRegistrarJugador2.Click += new System.EventHandler(this.btnRegistrarJugador2_Click);
            //
            // txtContraseña2
            //
            this.txtContraseña2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña2.Location = new System.Drawing.Point(165, 100);
            this.txtContraseña2.Name = "txtContraseña2";
            this.txtContraseña2.PasswordChar = '●';
            this.txtContraseña2.Size = new System.Drawing.Size(240, 32);
            this.txtContraseña2.TabIndex = 3;
            //
            // lblContraseñaCaption2
            //
            this.lblContraseñaCaption2.AutoSize = true;
            this.lblContraseñaCaption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseñaCaption2.ForeColor = System.Drawing.Color.Black;
            this.lblContraseñaCaption2.Location = new System.Drawing.Point(25, 103);
            this.lblContraseñaCaption2.Name = "lblContraseñaCaption2";
            this.lblContraseñaCaption2.Size = new System.Drawing.Size(115, 28);
            this.lblContraseñaCaption2.TabIndex = 2;
            this.lblContraseñaCaption2.Text = "Contraseña:";
            //
            // txtNombre2
            //
            this.txtNombre2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre2.Location = new System.Drawing.Point(165, 45);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(240, 32);
            this.txtNombre2.TabIndex = 1;
            //
            // lblUsuarioCaption2
            //
            this.lblUsuarioCaption2.AutoSize = true;
            this.lblUsuarioCaption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioCaption2.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioCaption2.Location = new System.Drawing.Point(25, 48);
            this.lblUsuarioCaption2.Name = "lblUsuarioCaption2";
            this.lblUsuarioCaption2.Size = new System.Drawing.Size(85, 28);
            this.lblUsuarioCaption2.TabIndex = 0;
            this.lblUsuarioCaption2.Text = "Usuario:";
            //
            // btnIniciarPartida
            //
            this.btnIniciarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(100)))));
            this.btnIniciarPartida.Enabled = false;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.Location = new System.Drawing.Point(370, 385);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(210, 55);
            this.btnIniciarPartida.TabIndex = 3;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            //
            // btnEstadisticas
            //
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Location = new System.Drawing.Point(600, 385);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(210, 55);
            this.btnEstadisticas.TabIndex = 4;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1010, 480);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.grpJugador2);
            this.Controls.Add(this.grpJugador1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpJugador1.ResumeLayout(false);
            this.grpJugador1.PerformLayout();
            this.grpJugador2.ResumeLayout(false);
            this.grpJugador2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpJugador1;
        private System.Windows.Forms.Button btnLogoutJugador1;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Button btnLoginJugador1;
        private System.Windows.Forms.Button btnRegistrarJugador1;
        private System.Windows.Forms.TextBox txtContraseña1;
        private System.Windows.Forms.Label lblContraseñaCaption1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblUsuarioCaption1;
        private System.Windows.Forms.GroupBox grpJugador2;
        private System.Windows.Forms.Button btnLogoutJugador2;
        private System.Windows.Forms.Label lblJugador2;
        private System.Windows.Forms.Button btnLoginJugador2;
        private System.Windows.Forms.Button btnRegistrarJugador2;
        private System.Windows.Forms.TextBox txtContraseña2;
        private System.Windows.Forms.Label lblContraseñaCaption2;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label lblUsuarioCaption2;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

