using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class vtnAdmin : Form
    {
        public vtnAdmin()
        {
            InitializeComponent();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnReportes();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnAgregarElementos_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarElementos();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnGestionarEntrenador();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnIniciarSe_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnIniciarSesion();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
