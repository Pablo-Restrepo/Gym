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
    public partial class vtnAgregarProveedor : Form
    {
        String connectionString = UserCache.conexion;
        public vtnAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int insert;
            string sql = "INSERT INTO PROVEEDOR(PROVE_NIT,PROVE_NOMBRE,PROVE_TELEFONO,PROVE_DIRECCION,PROVE_CORREO) VALUES ("+txtNIT.Text+",'"+txtNombre.Text+"',"+txtTelefono.Text+",'"+txtDireccion.Text+"','"+txtCorreo.Text+"')";
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

        private void Devolver_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarElementos();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
    
}
