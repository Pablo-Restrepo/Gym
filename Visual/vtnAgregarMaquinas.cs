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
using Proyecto.modelo;
using Oracle.ManagedDataAccess.Client;

namespace Visual
{
    public partial class vtnAgregarMaquinas : Form
    {
        String connectionString = UserCache.conexion;
        String maqFotoLocation;
        clsMaquina maquina = new clsMaquina();


        public vtnAgregarMaquinas()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int insert;
        int MaqCodigo = int.Parse(txtCod.Text);
        String MaqNombre = this.txtNombre.Text;
        float MaqPeso = float.Parse(txtPeso.Text);
        String MaqTipoMaquina = this.cbxTipoMaquina.Text;
        String MaqMusculoTrabaja = this.txtMusculoTraba.Text;
        String MaqMarca = this.txtMarca.Text;
            FileStream fileStream = new FileStream(maqFotoLocation, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStream);
            byte[] MaqFoto = new byte[fileStream.Length];
            MaqFoto = reader.ReadBytes((int)MaqFoto.Length);
            Console.Write(MaqFoto);
            string sql = "INSERT INTO MAQUINA(MAQ_CODIGO,MAQ_NOMBRE,MAQ_PESO,MAQ_TIPOMAQUINA,MAQ_MUSCULOTRABAJA,MAQ_MARCA,MAQ_FOTO) VALUES("+txtCod.Text+",'"+txtNombre.Text+"',"+txtPeso.Text+",'"+ cbxTipoMaquina.Text+"','"+txtMusculoTraba.Text+"','" +txtMarca.Text+"',:img)";
            OracleConnection miconexion = new OracleConnection();
            try
            {
                miconexion.ConnectionString = connectionString;
                miconexion.Open();
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miconexion;
                sqlInsert.Parameters.Add(new OracleParameter(":img",MaqFoto));
                insert = sqlInsert.ExecuteNonQuery();
                MessageBox.Show(insert.ToString()+"Guardado");
                miconexion.Close();

            }
            catch (Exception ex) {

                miconexion.Close();
                MessageBox.Show(ex.Message);
            
            }


        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "JPG FILES (*.jpg)|*.jpg|";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    maqFotoLocation = ofd.FileName.ToString();
                    this.pictureBox1.ImageLocation = maqFotoLocation;
                }
            }
            catch (Exception ex){
                MessageBox.Show("Formato DE archivo incorrecto", ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Form formulario = new vtnAgregarElementos();
            this.Hide();
            formulario.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
}
