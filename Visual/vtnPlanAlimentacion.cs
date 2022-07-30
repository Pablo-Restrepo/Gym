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
    public partial class vtnPlanAlimentacion : Form
    {
        String connectionString = UserCache.conexion;
        List<clsEjercicio> datos = new List<clsEjercicio>();
        List<clsMaquina> datosp = new List<clsMaquina>();
        MemoryStream ms = new MemoryStream();
        byte[] MisDatos = new byte[0];
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();
        public vtnPlanAlimentacion()
        {
            InitializeComponent();
        }

        private void vtnProteinas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnAlimentacion());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                DataSet dataSet = new DataSet();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "INSERT INTO ASIGNA(usu_login,plan_id) VALUES('" + UserCache.User + "'," + label2.Text + ")";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                int inserto = sqlInsert.ExecuteNonQuery();
                if (inserto > 0)
                {
                    MessageBox.Show("Plan de Alimentacion Agredado!");
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Error!. Ya tienes este plan agregado!");
            }
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
    }
}
