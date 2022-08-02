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
using Oracle.ManagedDataAccess.Client;
using Visual.modelo;

namespace Visual
{
    public partial class Form1 : Form
    {
        private object aux = 1;
        String connectionString = UserCache.conexion;
        Boolean aux1 = false;
        Form fH;
        Boolean examenM = false;
        public Form1()
        {
            InitializeComponent();
            abrirFormHija(new vtnInicio());
            aux1 = true;
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
                if (fH != null)
                {
                    fH.Dispose();
                }
                fH = formHija as Form;
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
            comprobarExamen();
            if (examenM)
            {
                if (comprobar())
                {
                    abrirFormHija(new vtnEntrenador());
                }
                else
                {
                    MessageBox.Show("Compre un plan para continuar");
                }
            }
            else
            {
                MessageBox.Show("Realize el examen medico primero");
            }
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnAcercaDe());
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean comprobar()
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                DataSet dataSet = new DataSet();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "SELECT * FROM compra WHERE usu_login = '" + UserCache.User + "'";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;
                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dataSet);
                }
                miConexion.Close();

                if (dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1].ItemArray[1].ToString().Equals("Base2") || dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1].ItemArray[1].ToString().Equals("Base3"))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                miConexion.Close();
                return false;
            }
        }
        private void comprobarExamen()
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                DataSet dataSet = new DataSet();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "SELECT EXA_NOMBRE FROM USUARIO WHERE usu_login = '" + UserCache.User + "'";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;
                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dataSet);
                }
                miConexion.Close();
                if (!dataSet.Tables[0].Rows[0].ItemArray[0].ToString().Equals(""))
                {
                    examenM = true;
                }
                else
                {
                    examenM = false;
                }
            }
            catch (Exception ex)
            {
                miConexion.Close();
            }
        }
    }
}
