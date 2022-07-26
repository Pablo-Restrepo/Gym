using Oracle.ManagedDataAccess.Client;
using Proyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.modelo;

namespace Visual
{
    public partial class vtnProducto : Form
    {

        String connectionString = UserCache.conexion;

        public vtnProducto()
        {
            InitializeComponent();
        }

        private void vtnProteinas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnProteinas());
        }
        private void abrirFormHija(object formHija)
        {
            if (this.panelCentro.Controls.Count > 0)
            {
                this.panelCentro.Controls.Clear();
            }

            Form fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panelCentro.Controls.Add(fH);
            this.panelCentro.Tag = fH;
            fH.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            Random r = new Random();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "INSERT INTO COMPRA1(comp1_cantidad , comp1_codreclamar , comp1_fechacompra , comp1_total , prod_codbarras , usu_login)  VALUES(" + lblCantidad.Text + "," + r.Next(0, 999999) + ",'" + DateTime.Now.ToString("dd-MM-yyyy") + "'," + lblPrecio.Text + "," + lblCodBarras.Text + ",'" + UserCache.User + "')";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                int inserto = sqlInsert.ExecuteNonQuery();
                if (inserto > 0)
                {
                    MessageBox.Show("Comprado!");
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
