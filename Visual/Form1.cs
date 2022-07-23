using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.accesoDatos;
using Oracle.ManagedDataAccess.Client;

namespace Visual
{
    public partial class Form1 : Form
    {
        private object aux = 1;
        //Datos conexion = new Datos();

        public Form1()
        {
            InitializeComponent();
            abrirFormHija(new vtnInicio());
            //conexion.abrir();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamanio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnTamanio.Visible = false;
            btnTamanio2.Visible = true;
        }
        private void btnTamanio2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnTamanio2.Visible = false;
            btnTamanio.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnTamanio2.Visible = false;
            btnTamanio.Visible = true;
        }

        private void panelBarraTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menulVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void abrirFormHija(object formHija)
        {
            if (aux.Equals(formHija.GetType().Name))
            {
                
            }
            else {
                if (this.panelCentral.Controls.Count > 0)
                {
                    this.panelCentral.Controls.Clear();
                }
                Form fH = formHija as Form;
                fH.TopLevel = false;
                fH.Dock = DockStyle.Fill;
                this.panelCentral.Controls.Add(fH);
                this.panelCentral.Tag = fH;
                fH.Show();
            }
            aux = formHija.GetType().Name;
        }
        private void Rutinas_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnRutina());
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            aux = 1;
            abrirFormHija(new vtnInicio());
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnBuscar());
        }

        private void Adicional_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnAdicional());
        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnCompra());
        }

        private void Entrenador_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnEntrenador());
        }

        private void Nutricion_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnNutricion());
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnAcercaDe());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
