using Oracle.ManagedDataAccess.Client;
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

namespace Visual
{
    public partial class vtnIniciarSesion : Form
    {
        String connectionString = "Data Source=localhost:1521/xe;User Id=pablo;Password=oracle";
        public vtnIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            pbLogo.Visible = false;
            pbLogoIniciarSes.Visible = false;
            btnRegistrarse.Visible = true;
            txtUsuario.Visible = true;
            cbxSexo.Visible = true;
            dtpFechaNacimiento.Visible = true;
            txtCiudad.Visible = true;
            txtContrasenia.Visible = true;
            txtRecContrasenia.Visible = true;
            txtCorreo.Visible = true;
            txtTarjCredito.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtCedula.Visible = true;
            txtPeso.Visible = true;
            txtAltura.Visible = true;
            btnVolver.Visible = true;
            pbRegistr.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            string sql = "";
            int inserto = 0;
            if (txtContrasenia.Equals(txtRecContrasenia)) { 
                
            }
            else
            {
                MessageBox.Show("Error!. La contraseña es erronea. Retificar.");
            }

            if (!comprobarUsuario())
            {
                MessageBox.Show("ta bien el user");
            }
            else
            {
                MessageBox.Show("Error!. El usuario ya existe. Use otro.");
            }

            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();

                sql = "INSERT INTO PERSONA (PER_CEDULA,PER_NOMBRE,PER_APELLIDO,PER_FECHANACI,PER_SEXO,PER_PESO,PER_ALTURA) VALUES (" + txtCedula.Text + ",'" + txtNombre.Text +"','" + txtApellido.Text + "','" + dtpFechaNacimiento.Text + "','" + cbxSexo.Text + "'," + txtPeso.Text + "," + txtAltura.Text + ")";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                inserto = sqlInsert.ExecuteNonQuery();

                sql = "INSERT INTO CLIENTE (PER_CEDULA,PER_NOMBRE,PER_APELLIDO,PER_FECHANACI,PER_SEXO,PER_PESO,PER_ALTURA,CLI_TARJETACREDITO,CLI_CIUDAD) VALUES (" + txtCedula.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + dtpFechaNacimiento.Text + "','" + cbxSexo.Text + "'," + txtPeso.Text + "," + txtAltura.Text + "," + txtTarjCredito.Text + ",'" + txtCiudad.Text + "')";
                OracleCommand sqlInsert2 = new OracleCommand(sql);
                sqlInsert2.Connection = miConexion;
                inserto = sqlInsert2.ExecuteNonQuery();

                sql = "INSERT INTO USUARIO (USU_LOGIN,PER_CEDULA,USU_PASSWORD,USU_CORREO) VALUES ('" + txtUsuario.Text + "'," + txtCedula.Text +  ",'" + txtContrasenia.Text + "','" + txtCorreo.Text + "')";
                OracleCommand sqlInsert3 = new OracleCommand(sql);
                sqlInsert3.Connection = miConexion;
                inserto = sqlInsert3.ExecuteNonQuery();

                sql = "UPDATE CLIENTE SET USU_LOGIN = '" + txtUsuario.Text + "' WHERE PER_CEDULA = " + txtCedula.Text;
                OracleCommand sqlInsert4 = new OracleCommand(sql);
                sqlInsert4.Connection = miConexion;
                inserto = sqlInsert4.ExecuteNonQuery();

                if (inserto > 0)
                {
                    MessageBox.Show("Se registro correctamente!");
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

            pbLogo.Visible = true;
            pbLogoIniciarSes.Visible = true;
            btnRegistrarse.Visible = false;
            cbxSexo.Visible = false;
            dtpFechaNacimiento.Visible = false;
            txtUsuario.Visible = false;
            txtCiudad.Visible = false;
            txtContrasenia.Visible = false;
            txtRecContrasenia.Visible = false;
            txtCorreo.Visible = false;
            txtTarjCredito.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtCedula.Visible = false;
            txtPeso.Visible = false;
            txtAltura.Visible = false;
            pbRegistr.Visible = false;
            btnVolver.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pbLogo.Visible = true;
            pbLogoIniciarSes.Visible = true;
            btnRegistrarse.Visible = false;
            cbxSexo.Visible = false;
            dtpFechaNacimiento.Visible = false;
            txtUsuario.Visible = false;
            txtCiudad.Visible = false;
            txtContrasenia.Visible = false;
            txtRecContrasenia.Visible = false;
            txtCorreo.Visible = false;
            txtTarjCredito.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtCedula.Visible = false;
            txtPeso.Visible = false;
            txtAltura.Visible = false;
            pbRegistr.Visible = false;
            btnVolver.Visible = false;
        }
        private Boolean comprobarUsuario()
        {
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "";
            int inserto = 0;
            sql = "SELECT USU_LOGIN FROM USUARIO WHERE USU_LOGIN = '" + txtUsuario.Text + "'";
            OracleCommand sqlInsert = new OracleCommand(sql);
            sqlInsert.Connection = miConexion;
            inserto = sqlInsert.ExecuteNonQuery();

            if (inserto > 0)
            {
                MessageBox.Show("Se registro correctamente!");
            }
            
            if (Convert.ToString(sqlInsert.ExecuteScalar()).Equals(txtUsuario.Text))
            {
                return true;
            }

            miConexion.Close();

            return false;
        }
    }
}
