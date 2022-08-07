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
using Oracle.ManagedDataAccess.Client;

namespace Visual
{
    public partial class vtnReportes : Form
    {
        String connectionString = UserCache.conexion;
        public vtnReportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "Select MAQUINA.MAQ_MUSCULOTRABAJA MUSCULOTRABAJA, COUNT(*) CANTIDAD from MAQUINA GROUP BY MAQUINA.MAQ_MUSCULOTRABAJA ORDER BY COUNT(*) DESC";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRutinasUsadas_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT RUTINA.RUT_NOMBRE, RUTINA.RUT_TIPOTRENEJER, T.NUMEROPERSONAS FROM RUTINA INNER JOIN (SELECT TIENE1.RUT_ID, COUNT(*) NUMEROPERSONAS FROM TIENE1 GROUP BY TIENE1.RUT_ID) T ON RUTINA.RUT_ID = T.RUT_ID ORDER BY T.NUMEROPERSONAS DESC";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void botonEntrenadoresAseoran_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT ENTRENADOR.PER_NOMBRE, ENTRENADOR.ENTRE_SALARIO, T.PERSONASASESORADAS FROM ENTRENADOR INNER JOIN (SELECT PER_CEDULA, COUNT(*) PERSONASASESORADAS FROM ASESORA GROUP BY PER_CEDULA) T ON ENTRENADOR.PER_CEDULA = T.PER_CEDULA ORDER BY T.PERSONASASESORADAS DESC";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAdmin();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();

        }

        private void btnProductosMasComprados_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "select T.PROD_NOMBRE,COMPRA1.PROD_CODBARRAS, count(COMPRA1.PROD_CODBARRAS) as total from COMPRA1 inner join (select PROD_CODBARRAS ,PROD_NOMBRE FROM PRODUCTO)T ON COMPRA1.PROD_CODBARRAS = T.PROD_CODBARRAS group by COMPRA1.PROD_CODBARRAS,T.PROD_NOMBRE order by total desc";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCompradasMayor_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "select COMPRA.SUS_NOMBRE, count(COMPRA.SUS_NOMBRE) as total from COMPRA group by COMPRA.SUS_NOMBRE order by total desc";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
