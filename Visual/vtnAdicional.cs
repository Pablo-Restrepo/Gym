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
using Visual.modelo;

namespace Visual
{
    public partial class vtnAdicional : Form
    {
        String connectionString = UserCache.conexion;
        public vtnAdicional()
        {
            InitializeComponent();
        }

        private void vtnAdicional_Load(object sender, EventArgs e)
        {

        }

        private void btnBas_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "INSERT INTO compra (usu_login , sus_nombre , comp_fechaactiv ) VALUES ('" + UserCache.User + "', 'Base','" + DateTime.Now.ToString("dd - MM - yyyy") + "')";
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

        private void btnEntre_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "INSERT INTO compra (usu_login , sus_nombre , comp_fechaactiv ) VALUES ('" + UserCache.User + "', 'Base2','" + DateTime.Now.ToString("dd - MM - yyyy") + "')";
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

        private void btnComp_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "INSERT INTO compra (usu_login , sus_nombre , comp_fechaactiv ) VALUES ('" + UserCache.User + "', 'Base3','" + DateTime.Now.ToString("dd - MM - yyyy") + "')";
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
