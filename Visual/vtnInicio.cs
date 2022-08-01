using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.modelo;

namespace Visual
{
    public partial class vtnInicio : Form
    {
        String connectionString = UserCache.conexion;
        Boolean baseB = false;
        Boolean baseE = false;
        Boolean baseC = false;
        Form fH;
        public vtnInicio()
        {
            InitializeComponent();
        }

        private void vtnInicio_Load(object sender, EventArgs e)
        {
            comprobarSuscrip();
            infoUser();
        }

        private void abrirFormHija(object formHija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.Clear();
            }
            if (fH != null)
            {
                fH.Dispose();
            }
            fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fH);
            this.panel1.Tag = fH;
            fH.Show();
        }
        private void Rutinas_Click(object sender, EventArgs e)
        {
            if (baseB)
            {
                abrirFormHija(new vtnRutina());
            }
            else
            {
                MessageBox.Show("Compre un plan para continuar");
            }
        }

        private void Alimentacion_Click(object sender, EventArgs e)
        {
            if (baseC)
            {
                abrirFormHija(new vtnAlimentacion());
            }
            else
            {
                MessageBox.Show("Compre un plan para continuar");
            }
        }

        private void TrenS_Click(object sender, EventArgs e)
        {
            if (baseB)
            {
                abrirFormHija(new vtnTrenSu());
            }
            else
            {
                MessageBox.Show("Compre un plan para continuar");
            }
        }

        private void TrenI_Click(object sender, EventArgs e)
        {
            if (baseB)
            {
                abrirFormHija(new vtnTrenIn());
            }
            else
            {
                MessageBox.Show("Compre un plan para continuar");
            }
        }

        private void Otros_Click(object sender, EventArgs e)
        {
            if (baseB)
            {
                abrirFormHija(new vtnOtrosE());
            }
            else
            {
                MessageBox.Show("Compre un plan para continuar");
            }
        }

        private void Proteina_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnProteinas());
        }

        private void Maquina_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnMaquinas());
        }

        private void OtrosP_Click(object sender, EventArgs e)
        {
            abrirFormHija(new vtnOtrosP());
        }
        private void comprobarSuscrip()
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                DataSet dataSet = new DataSet();
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "SELECT * FROM compra WHERE usu_login = '" + UserCache.User + "'";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.CommandType = CommandType.Text;
                sqlSelect.Connection = miConexion;
                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dataSet);
                }
                miConexion.Close();
                if (dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count -1].ItemArray[1].ToString().Equals("Base"))
                {
                    baseB = true;
                }
                else if (dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count -1].ItemArray[1].ToString().Equals("Base2"))
                {
                    baseB = true;
                    baseE = true;
                }
                else if (dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count -1].ItemArray[1].ToString().Equals("Base3"))
                {
                    baseB = true;
                    baseE = true;
                    baseC = true;
                }
            }
            catch (Exception ex)
            {
                miConexion.Close();
            }
        }
        private void infoUser()
        {
            lblUserNombre.Text = UserCache.User;
            try
            {
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
                gp.AddEllipse(0, 0, pbFotoUser.Width - 3, pbFotoUser.Height - 3);
                Region rg = new Region(gp);
                pbFotoUser.Region = rg;
                MemoryStream ms = new MemoryStream();
                ms = new MemoryStream(UserCache.PerFoto);
                pbFotoUser.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {
            }
            
        }

        private void pbFotoUser_Click(object sender, EventArgs e)
        {

        }
    }
}
