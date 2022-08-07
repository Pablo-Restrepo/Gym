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
    public partial class vtnAgregarCurso : Form
    {
        String connectionString = UserCache.conexion;
        public vtnAgregarCurso()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            int insert;
            string sql = "INSERT INTO CURSO(CUR_ID,CUR_NOMBRE,CUR_DESCRIPCION,PER_CEDULA) VALUES ("+txtID.Text+",'"+txtNombre.Text+"','"+txtDescripcion.Text+"',"+txtEntrenadorCedula.Text+")";
            OracleConnection miconexion = new OracleConnection();
            miconexion.ConnectionString = connectionString;
            try
            {
                miconexion.Open();
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miconexion;
                insert = sqlInsert.ExecuteNonQuery();
                MessageBox.Show(insert.ToString() + "Guardado");
                miconexion.Close();

            }
            catch (Exception ex)
            {

                miconexion.Close();
                MessageBox.Show(ex.Message);

            }

        }

        private void InicializarTabla() {
            try
            {
                DataTable dt = new DataTable();
                OracleConnection miConexion = new OracleConnection();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "SELECT * FROM ENTRENADOR";
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
