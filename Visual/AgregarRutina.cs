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
    public partial class AgregarRutina : Form
    {
        String connectionString = UserCache.conexion;
        public AgregarRutina()
        {
            InitializeComponent();
            inicialiartabla();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean bandera = false;
            DataTable dt = new DataTable();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT PER_CEDULA FROM ASESORA WHERE PER_CEDULA LIKE'" + txtPerCedula.Text + "'";
            OracleCommand sqlSelect = new OracleCommand(sql);
            sqlSelect.CommandType = CommandType.Text;
            sqlSelect.Connection = miConexion;

            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = sqlSelect;
                dataAdapter.Fill(dt);
                miConexion.Close();
            }

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Erro!, Este Entrenador esta Asesorando un usuario en este momento");

            }
            else
            {
                try
                {
                    int insert;
                    miConexion.Open();
                    sql = "INSERT INTO RUTINA(RUT_ID,PER_CEDULA,RUT_NOMBRE,RUT_TIPOTRENEJER) VALUES(" + txtID.Text + "," + txtPerCedula.Text + ",'" + txtNombre.Text + "','" + cbxTipoRutina.Text + "')";
                    sqlSelect = new OracleCommand(sql);
                    sqlSelect.Connection = miConexion;
                    insert = sqlSelect.ExecuteNonQuery();
                    MessageBox.Show("Dato Guardado");
                    miConexion.Close();



                }
                catch (Exception ex)
                {
                    miConexion.Close();
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void inicialiartabla() {
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
