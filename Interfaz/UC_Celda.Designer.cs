namespace Interfaz
{
    partial class UC_Celda
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCelda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCelda
            // 
            this.btnCelda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCelda.Location = new System.Drawing.Point(0, 0);
            this.btnCelda.Name = "btnCelda";
            this.btnCelda.Size = new System.Drawing.Size(150, 150);
            this.btnCelda.TabIndex = 0;
            this.btnCelda.Text = "button1";
            this.btnCelda.UseVisualStyleBackColor = true;
            this.btnCelda.Click += new System.EventHandler(this.btnCelda_Click);
            // 
            // UC_Celda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCelda);
            this.Name = "UC_Celda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCelda;
    }
}
