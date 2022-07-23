using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.accesoDatos;

namespace Visual
{
    public partial class vtnRutina : Form
    {
        String connectionString =
            "Data Source=localhost:1521/xe;User Id=system;Password=oracle";
        public vtnRutina()
        {
            InitializeComponent();
        }

        private void vtnRutina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT * FROM CANTANTE ";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.Connection = miConexion;
                var dr = sqlSelect.ExecuteReader();

                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
