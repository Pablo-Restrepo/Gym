using Oracle.ManagedDataAccess.Client;
using Proyecto.modelo;
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
    public partial class vtnCompra : Form
    {
        String connectionString = UserCache.conexion;
        List<clsProducto> datos = new List<clsProducto>();
        MemoryStream ms = new MemoryStream();
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();
        public vtnCompra()
        {
            InitializeComponent();
        }

        private void vtnCompra_Load(object sender, EventArgs e)
        {
            limpiar();
            generarProductos();
        }
        private void limpiar()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT * FROM compra1 INNER JOIN PRODUCTO ON compra1.prod_codbarras =  producto.prod_codbarras WHERE usu_login = '" + UserCache.User + "'ORDER BY producto.prod_codbarras";
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

                    cartel.ProdNombre = dataSet.Tables[0].Rows[j].ItemArray[8].ToString();
                    cartel.ProdPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[2].ToString());
                    if (dataSet.Tables[0].Rows[j].ItemArray[11].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("a\\default.png");
                        cartel.ProdFoto = imagen;
                    }
                    else
                    {
                        cartel.ProdFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[11];
                    }

                    datos.Add(cartel);
                }
            }
        }

        private void generarProductos()
        {
            int posX, posY;
            int ancho, alto;

            Pcontener.Controls.Clear();

            ancho = (Pcontener.Width / 6);
            alto = (Pcontener.Height / 3);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 5;

            for (int i = 0; i < datos.Count; i++)
            {
                p = new Panel();
                title = new Label();
                costo = new Label();
                cant++;

                ms = new MemoryStream(datos[i].ProdFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);

                title.Text = datos[i].ProdNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.BackColor = Color.Black;
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = "Cod: " + datos[i].ProdPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.BackColor = Color.Green;
                costo.TabIndex = i;

                p.Controls.Add(title);
                p.Controls.Add(costo);
                title.Location = new Point(0, 5);
                costo.Location = new Point(0, (p.Height - costo.Height));

                Pcontener.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (Pcontener.Controls.Count > 0)
                {
                    posX = posX + ancho + 38;
                }

                if (cant == incrementa)
                {
                    incrementa = incrementa + 5;
                    posX = 0;
                    posY = posY + alto + 38;
                }
            }
        }
    }
}
