using System;
using System.IO;
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
    public partial class vtnAgregarEntrenador : Form
    {
        String connectionString = UserCache.conexion;
        String FotoLocation;
        public vtnAgregarEntrenador()
        {
            InitializeComponent();
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "JPG FILES (*.jpg)|*.jpg|";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FotoLocation = ofd.FileName.ToString();
                    this.pictureBox1.ImageLocation = FotoLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato DE archivo incorrecto", ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            int insert;
            FileStream fileStream = new FileStream(FotoLocation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            byte[] MaqFoto = new byte[fileStream.Length];
            MaqFoto = reader.ReadBytes((int)MaqFoto.Length);
            string sql = "INSERT INTO PERSONA(PER_CEDULA,PER_NOMBRE,PER_APELLIDO,PER_FECHANACI,PER_SEXO,PER_PESO,PER_ALTURA,PER_FOTO) VALUES (" + txtCedula.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + dateTimeFechaNaci.Text + "','" + cbxSexo.Text + "'," + txtPeso.Text + "," + txtAlura.Text + ",:img)";
            OracleConnection miconexion = new OracleConnection();
            miconexion.ConnectionString = connectionString;
            try
            {
                miconexion.Open();
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miconexion;
                sqlInsert.Parameters.Add(new OracleParameter(":img", MaqFoto));
                insert = sqlInsert.ExecuteNonQuery();
                MessageBox.Show(insert.ToString() + "Guardado");
                miconexion.Close();

            }
            catch (Exception ex)
            {

                miconexion.Close();
                MessageBox.Show(ex.Message);

            }
            sql = "INSERT INTO ENTRENADOR(PER_CEDULA,PER_NOMBRE,PER_APELLIDO,PER_FECHANACI,PER_SEXO,PER_PESO,PER_ALTURA,ENTRE_SALARIO,PER_FOTO) VALUES (" + txtCedula.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + dateTimeFechaNaci.Text + "','" + cbxSexo.Text + "'," + txtPeso.Text + "," + txtAlura.Text + "," + txtSalario.Text + ",:img)";
            try
            {
                miconexion.Open();
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miconexion;
                sqlInsert.Parameters.Add(new OracleParameter(":img", MaqFoto));
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
