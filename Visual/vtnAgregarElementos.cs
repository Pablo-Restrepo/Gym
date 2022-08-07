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
    public partial class vtnAgregarElementos : Form
    {
        public vtnAgregarElementos()
        {
            InitializeComponent();
        }

        private void bntAgregarMaquina_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarMaquinas();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnAgregarEjericios_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarEjercicio();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnAgregarProvedor_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarProveedor();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();

        }

        private void bntAgregarProducto_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarProducto();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAdmin();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }
}
