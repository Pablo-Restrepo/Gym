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
    public partial class vtnEntrenador : Form
    {
        String connectionString = UserCache.conexion;
        List<clsEntrenador> datos = new List<clsEntrenador>();
        List<clsCurso> datosp = new List<clsCurso>();
        MemoryStream ms = new MemoryStream();
        byte[] MisDatos = new byte[0];
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();

        public vtnEntrenador()
        {
            InitializeComponent();
        }

        private void vtnEntrenador_Load(object sender, EventArgs e)
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
            string sql = "SELECT * FROM entrenador inner join capacita on entrenador.per_cedula = capacita.per_cedula inner join curso on curso.cur_id = capacita.cur_id";
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
                    clsEntrenador cartel = new clsEntrenador();

                    cartel.PerCedula = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    cartel.PerNombre = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                    cartel.PerApellido = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.PerSexo = dataSet.Tables[0].Rows[j].ItemArray[4].ToString();
                    if (dataSet.Tables[0].Rows[j].ItemArray[7].ToString().Equals(""))
                    {
                        byte[] imagen = File.ReadAllBytes("..\\..\\Resources\\default.png");
                        cartel.PerFoto = imagen;
                    }
                    else
                    {
                        cartel.PerFoto = (byte[])dataSet.Tables[0].Rows[j].ItemArray[7];
                    }

                    datos.Add(cartel);

                    clsCurso cartelp = new clsCurso();

                    cartelp.Cur_nombre = dataSet.Tables[0].Rows[j].ItemArray[12].ToString();
                    cartelp.Cur_descripcion = dataSet.Tables[0].Rows[j].ItemArray[13].ToString();

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
                cant++;

                ms = new MemoryStream(datos[i].PerFoto);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos[i].PerNombre + " " + datos[i].PerApellido;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.BackColor = Color.Black;
                title.ForeColor = Color.White;
                title.TabIndex = i;

                p.Controls.Add(title);
                p.Controls.Add(costo);
                title.Location = new Point(0, 5);

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
            vtnEntrenadores a = new vtnEntrenadores();
            a.lblNombre.Text = datos[p.TabIndex].PerNombre + " " + datos[p.TabIndex].PerApellido;
            a.lblCantidad.Text = datos[p.TabIndex].PerCedula.ToString();
            a.lblPrecio.Text = datos[p.TabIndex].PerSexo.ToString();
            ms = new MemoryStream(datos[p.TabIndex].PerFoto);
            a.pbProducto.Image = Image.FromStream(ms);

            a.lblProNIT.Text = "Curso:  " + datosp[p.TabIndex].Cur_nombre.ToString();
            a.lblProveMonbre.Text = "Descripcion: " + datosp[p.TabIndex].Cur_descripcion.ToString();

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
