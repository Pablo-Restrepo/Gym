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
    public partial class vtnCapacita : Form
    {
        String connectionString = UserCache.conexion;
        public vtnCapacita()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean bandera = false;
            DataTable dt = new DataTable();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT CUR_ID FROM CURSO WHERE PER_CEDULA LIKE'"+txtCedulaEntrenador.Text+"'";
            OracleCommand sqlSelect = new OracleCommand(sql);
            sqlSelect.CommandType = CommandType.Text;
            sqlSelect.Connection = miConexion;

            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = sqlSelect;
                dataAdapter.Fill(dt);
                miConexion.Close();
            }

            if (dt.Rows.Count > 0) {
                for (int i = 0; i < dt.Rows.Count; i++) {
                    if (dt.Rows[i][0].ToString() == txtIDcurso.Text) {
                        MessageBox.Show("Error!, El Entreandor que vas a capacitar es el que dicta este curso");
                        bandera = true;
                        break;
                    }

                }
            
            
            }

            if (!bandera) {
                try
                {
                    int insert;
                    miConexion.Open();
                    sql = "INSERT INTO CAPACITA(PER_CEDULA,CUR_ID) VAlUES ("+txtCedulaEntrenador.Text+","+txtIDcurso.Text+")";
                    sqlSelect = new OracleCommand(sql);
                    sqlSelect.Connection = miConexion;
                    insert = sqlSelect.ExecuteNonQuery();
                    MessageBox.Show("Dato Guardado");
                    miConexion.Close();



                }
                catch (Exception ex) {
                    miConexion.Close();
                    MessageBox.Show(ex.Message);
                }
            
            
            }




        }

        private void InicializarTabla()
        {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT PER_CEDULA CEDULA, PER_NOMBRE NOMBRE FROM ENTRENADOR";
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

            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT CUR_ID ID, CUR_NOMBRE NOMBRECURSO  FROM CURSO";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                    miConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnGestionarEntrenador();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();

        }
    }
}
