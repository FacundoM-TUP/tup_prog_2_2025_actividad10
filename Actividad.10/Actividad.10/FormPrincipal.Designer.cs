namespace Actividad._10
{
    partial class FormPrincipal
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsbVerSolicitudesImportadas = new System.Windows.Forms.ListBox();
            this.btnImportarSolicitudes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            this.lsbVerSolicitudesImportadas.FormattingEnabled = true;
            this.lsbVerSolicitudesImportadas.ItemHeight = 18;
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(25, 113);
            this.lsbVerSolicitudesImportadas.Margin = new System.Windows.Forms.Padding(4);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(243, 166);
            this.lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(25, 36);
            this.btnImportarSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(112, 45);
            this.btnImportarSolicitudes.TabIndex = 1;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 412);
            this.Controls.Add(this.btnImportarSolicitudes);
            this.Controls.Add(this.lsbVerSolicitudesImportadas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Button btnImportarSolicitudes;
    }
}

