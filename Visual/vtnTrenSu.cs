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
    public partial class vtnTrenSu : Form
    {
        String connectionString = UserCache.conexion;
        List<clsEjercicio> datos = new List<clsEjercicio>();
        List<clsMaquina> datosp = new List<clsMaquina>();
        MemoryStream ms = new MemoryStream();
        byte[] MisDatos = new byte[0];
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();
        public vtnTrenSu()
        {
            InitializeComponent();
        }

        private void vtnTrenSu_Load(object sender, EventArgs e)
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
            string sql = "SELECT * FROM EJERCICIO INNER JOIN MAQUINA ON EJERCICIO.MAQ_CODIGO = MAQUINA.MAQ_CODIGO WHERE EJER_TIPOTRENEJER= 'tren superior'";
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
                    clsEjercicio cartel = new clsEjercicio();

                    cartel.EjerSeries = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[3].ToString());
                    cartel.EjerNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.EjerTipoTrenEjer = dataSet.Tables[0].Rows[j].ItemArray[9].ToString();
                    cartel.EjerRepeSeries = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[4].ToString());
                    cartel.EjerDescripcion = dataSet.Tables[0].Rows[j].ItemArray[6].ToString();
                    cartel.EjerDescanso = dataSet.Tables[0].Rows[j].ItemArray[5].ToString();

                    if (dataSet.Tables[0].Rows[j].ItemArray[8].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("a\\default.png");
                        cartel.EjerFoto = imagen;
                    }
                    else
                    {
                        cartel.EjerFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[8];
                    }

                    datos.Add(cartel);

                    clsMaquina cartelp = new clsMaquina();

                    cartelp.MaqNombre = dataSet.Tables[0].Rows[j].ItemArray[11].ToString();
                    cartelp.MaqMusculoTrabaja = dataSet.Tables[0].Rows[j].ItemArray[14].ToString();
                    cartelp.MaqMarca = dataSet.Tables[0].Rows[j].ItemArray[15].ToString();

                    if (dataSet.Tables[0].Rows[j].ItemArray[16].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("a\\default.png");
                        cartelp.MaqFoto = imagen;
                    }
                    else
                    {
                        cartelp.MaqFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[16];
                    }

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

                ms = new MemoryStream(datos[i].EjerFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos[i].EjerNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.BackColor = Color.Black;
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = datos[i].EjerTipoTrenEjer.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            vtnEjercicio a = new vtnEjercicio();
            a.lblNombreProducto.Text = datos[p.TabIndex].EjerNombre;
            a.lblCantidad.Text = datos[p.TabIndex].EjerRepeSeries.ToString();
            a.lblPrecio.Text = datos[p.TabIndex].EjerSeries.ToString();
            a.lblCodBarras.Text = datos[p.TabIndex].EjerTipoTrenEjer.ToString();
            ms = new MemoryStream(datos[p.TabIndex].EjerFoto);
            a.pbProducto.Image = Image.FromStream(ms);
            a.lblDescr.Text = datos[p.TabIndex].EjerDescripcion.ToString();

            a.lblProveMonbre.Text = "Maquina:  " + datosp[p.TabIndex].MaqNombre.ToString();
            a.lblProNIT.Text = "Marca: " + datosp[p.TabIndex].MaqMarca.ToString();
            a.lblProveTelef.Text = "Musculo que Trabaja: " + datosp[p.TabIndex].MaqMusculoTrabaja.ToString();
            ms = new MemoryStream(datosp[p.TabIndex].MaqFoto);
            a.pbMaquina.Image = Image.FromStream(ms);

            a.aux = "s";

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
