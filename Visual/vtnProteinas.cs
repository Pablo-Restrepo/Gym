using Oracle.ManagedDataAccess.Client;
using Proyecto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class vtnProteinas : Form
    {
        String connectionString = "Data Source=localhost:1521/xe;User Id=pablo;Password=oracle";
        public vtnProteinas()
        {
            InitializeComponent();
        }

        private void vtnProteinas_Load(object sender, EventArgs e)
        {
            limpiar();
        }
        List<clsProducto> datos = new List<clsProducto>();
        MemoryStream ms = new MemoryStream();
        byte[] MisDatos = new byte[0];
        private void limpiar()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT * FROM PRODUCTO";
            OracleCommand sqlSelect = new OracleCommand(sql);
            sqlSelect.CommandType = CommandType.Text;
            sqlSelect.Connection = miConexion;

            using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
            {
                dataAdapter.SelectCommand = sqlSelect;
                dataAdapter.Fill(dataSet);
            }

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                {
                    clsProducto cartel = new clsProducto();
                    cartel.ProdNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.ProdFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[5];
                    cartel.ProdPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    datos.Add(cartel);
                }
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            PictureBox p = new PictureBox();
            Label title = new Label();
            Label costo = new Label();
            
            int posX, posY;
            int ancho, alto;

            Pcontener.Controls.Clear();

            ancho = (Pcontener.Width / 6);
            alto = (Pcontener.Height / 3);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 4;

            for (int i = 0; i < datos.Count; i++)
            {
                p = new PictureBox();
                title = new Label();
                costo = new Label();
                cant++;
                ms = new MemoryStream(datos[i].ProdFoto);
                p.Image = Image.FromStream(ms);
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Size = new Size(ancho, alto);

                title.Text = datos[i].ProdNombre;
                title.BackColor = Color.Red;
                title.ForeColor = Color.White;

                costo.Text = datos[i].ProdPrecio.ToString();
                costo.BackColor = Color.Orange;

                p.Controls.Add(title);
                p.Controls.Add(costo);
                title.Location = new Point(0, 5);
                costo.Location = new Point(0, (p.Height - costo.Height));

                Pcontener.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (Pcontener.Controls.Count > 0)
                {
                    posX = posX + ancho;
                }

                if (cant == incrementa)
                {
                    incrementa = incrementa + 4;
                    posX = 0;
                    posY = posY + alto;
                }
            }
        }
    }
}
