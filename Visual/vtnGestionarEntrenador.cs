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
    public partial class vtnGestionarEntrenador : Form
    {
        public vtnGestionarEntrenador()
        {
            InitializeComponent();
        }

        private void btnCrearEntrenador_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarEntrenador();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarCurso();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnCapacitarEntrenador_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnCapacita();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnCrearRutina_Click(object sender, EventArgs e)
        {
            Form formulario = new AgregarRutina();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAdmin();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }
}
