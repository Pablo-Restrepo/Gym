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
    public partial class vtnInicio : Form
    {
        public vtnInicio()
        {
            InitializeComponent();
        }

        private void vtnInicio_Load(object sender, EventArgs e)
        {

        }

        private void abrirFormHija(object formHija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.Clear();
            }

            Form fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fH);
            this.panel1.Tag = fH;
            fH.Show();
        }
        private void Rutinas_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnRutina());
        }

        private void Alimentacion_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnAlimentacion());
        }

        private void TrenS_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnTrenSu());
        }

        private void TrenI_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnTrenIn());
        }

        private void Otros_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnOtrosE());
        }

        private void Proteina_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnProteinas());
        }

        private void Maquina_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnMaquinas());
        }

        private void OtrosP_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnOtrosP());
        }
    }
}
