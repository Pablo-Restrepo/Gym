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
    public partial class vtnOtrosP : Form
    {
        String connectionString = UserCache.conexion;
        List<clsProducto> datos = new List<clsProducto>();
        List<clsProveedor> datosp = new List<clsProveedor>();
        MemoryStream ms = new MemoryStream();
        byte[] MisDatos = new byte[0];
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();
        public vtnOtrosP()
        {
            InitializeComponent();
        }

        private void vtnOtrosP_Load(object sender, EventArgs e)
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
            string sql = "SELECT * FROM PRODUCTO INNER JOIN PROVEEDOR ON PRODUCTO.PROVE_NIT = PROVEEDOR.PROVE_NIT WHERE PROD_TIPOPROD = 'otro'";
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

                    cartel.ProdCodBarras = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    cartel.ProdNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.ProdPrecio = float.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    cartel.ProdCantidad = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[4].ToString());
                    if (dataSet.Tables[0].Rows[j].ItemArray[5].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        cartel.ProdFoto = imagen;
                    }
                    else
                    {
                        cartel.ProdFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[5];
                    }

                    datos.Add(cartel);

                    clsProveedor cartelp = new clsProveedor();

                    cartelp.ProveNit = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[7].ToString());
                    cartelp.ProveNombre = dataSet.Tables[0].Rows[j].ItemArray[8].ToString();
                    cartelp.ProveTelefono = long.Parse(dataSet.Tables[0].Rows[j].ItemArray[9].ToString());
                    cartelp.ProveDireccion = dataSet.Tables[0].Rows[j].ItemArray[10].ToString();
                    cartelp.ProveCorreo = dataSet.Tables[0].Rows[j].ItemArray[11].ToString();

                    datosp.Add(cartelp);
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
                p.Cursor = Cursors.Hand;

                title.Text = datos[i].ProdNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.BackColor = Color.Black;
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = "$" + datos[i].ProdPrecio.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                p.Click += new EventHandler(cliquear);
            }
        }
        private void cliquear(object sender, EventArgs e)
        {
            p = new Panel();
            p = (Panel)sender;
            limpiar();
            vtnProducto a = new vtnProducto();
            a.lblNombreProducto.Text = datos[p.TabIndex].ProdNombre;
            a.lblCantidad.Text = datos[p.TabIndex].ProdCantidad.ToString();
            a.lblPrecio.Text = datos[p.TabIndex].ProdPrecio.ToString();
            a.lblCodBarras.Text = datos[p.TabIndex].ProdCodBarras.ToString();
            ms = new MemoryStream(datos[p.TabIndex].ProdFoto);
            a.pbProducto.Image = Image.FromStream(ms);

            a.lblProNIT.Text = "NIT:  " + datosp[p.TabIndex].ProveNit.ToString();
            a.lblProveMonbre.Text = "Proveedor: " + datosp[p.TabIndex].ProveNombre.ToString();
            a.lblProveTelef.Text = "Telefono: " + datosp[p.TabIndex].ProveTelefono.ToString();
            a.lblProveDirecc.Text = "Direccion: " + datosp[p.TabIndex].ProveDireccion.ToString();
            a.lblProvCorreo.Text = "Correo: " + datosp[p.TabIndex].ProveCorreo.ToString();

            abrirFormHija(a);
        }
        private void abrirFormHija(object formHija)
        {
            if (this.panelCentro.Controls.Count > 0)
            {
                this.panelCentro.Controls.Clear();
            }

            Form fH = formHija as Form;
            fH.TopLevel = false;
            fH.Dock = DockStyle.Fill;
            this.panelCentro.Controls.Add(fH);
            this.panelCentro.Tag = fH;
            fH.Show();
        }
    }
}
