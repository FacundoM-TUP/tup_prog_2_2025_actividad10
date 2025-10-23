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
            this.lbSolicitudSeleccionada = new System.Windows.Forms.Label();
            this.lsbColaSolicitudesAAtender = new System.Windows.Forms.ListBox();
            this.btnConfirmarAtencion = new System.Windows.Forms.Button();
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
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(13, 113);
            this.lsbVerSolicitudesImportadas.Margin = new System.Windows.Forms.Padding(4);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(243, 166);
            this.lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(13, 60);
            this.btnImportarSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(112, 45);
            this.btnImportarSolicitudes.TabIndex = 1;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // lbSolicitudSeleccionada
            // 
            this.lbSolicitudSeleccionada.Location = new System.Drawing.Point(263, 113);
            this.lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            this.lbSolicitudSeleccionada.Size = new System.Drawing.Size(146, 68);
            this.lbSolicitudSeleccionada.TabIndex = 2;
            this.lbSolicitudSeleccionada.Text = "seleccione de la lista";
            // 
            // lsbColaSolicitudesAAtender
            // 
            this.lsbColaSolicitudesAAtender.FormattingEnabled = true;
            this.lsbColaSolicitudesAAtender.ItemHeight = 18;
            this.lsbColaSolicitudesAAtender.Location = new System.Drawing.Point(415, 113);
            this.lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            this.lsbColaSolicitudesAAtender.Size = new System.Drawing.Size(212, 166);
            this.lsbColaSolicitudesAAtender.TabIndex = 3;
            // 
            // btnConfirmarAtencion
            // 
            this.btnConfirmarAtencion.Location = new System.Drawing.Point(263, 184);
            this.btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            this.btnConfirmarAtencion.Size = new System.Drawing.Size(146, 95);
            this.btnConfirmarAtencion.TabIndex = 4;
            this.btnConfirmarAtencion.Text = "confirmar a cola de atencion solicitud seleccionada";
            this.btnConfirmarAtencion.UseVisualStyleBackColor = true;
            this.btnConfirmarAtencion.Click += new System.EventHandler(this.btnConfirmarAtencion_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 401);
            this.Controls.Add(this.btnConfirmarAtencion);
            this.Controls.Add(this.lsbColaSolicitudesAAtender);
            this.Controls.Add(this.lbSolicitudSeleccionada);
            this.Controls.Add(this.btnImportarSolicitudes);
            this.Controls.Add(this.lsbVerSolicitudesImportadas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Button btnImportarSolicitudes;
        private System.Windows.Forms.Label lbSolicitudSeleccionada;
        private System.Windows.Forms.ListBox lsbColaSolicitudesAAtender;
        private System.Windows.Forms.Button btnConfirmarAtencion;
    }
}

