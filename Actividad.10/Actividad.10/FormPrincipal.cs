﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad._10.Models;

namespace Actividad._10
{
    public partial class FormPrincipal : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnImportarSolicitudes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    centro.ImportarCsvSolicitudesEntrantes(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }

            VerSolicitudesPendiente();
        }
        protected void VerSolicitudesPendiente()
        {
            lsbVerSolicitudesImportadas.Items.Clear();

            LinkedListNode<Solicitud> nodo = centro.GetSolicitudPendiente();

            while(nodo != null)
            {
                lsbVerSolicitudesImportadas.Items.Add(nodo.Value);
                nodo = nodo.Next;
            }
        }
    }
}