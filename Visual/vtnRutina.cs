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
    public partial class vtnRutina : Form
    {
        String connectionString = UserCache.conexion;
        List<clsRutina> datos = new List<clsRutina>();
        List<clsRutina> datos2 = new List<clsRutina>();
        MemoryStream ms = new MemoryStream();
        Panel p = new Panel();
        Label title = new Label();
        Label costo = new Label();
        public vtnRutina()
        {
            InitializeComponent();
        }

        private void vtnRutina_Load(object sender, EventArgs e)
        {
            limpiar1();
            generarProductos1();
            limpiar();
            generarProductos();
        }
        private void limpiar()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT * FROM RUTINA";
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
                    clsRutina cartel = new clsRutina();

                    cartel.RutId = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());
                    cartel.RutNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.RutTipoTrenEjer = dataSet.Tables[0].Rows[j].ItemArray[3].ToString();

                    datos.Add(cartel);
                }
            }
        }

        private void generarProductos()
        {
            int posX, posY;
            int ancho, alto;

            panelRutinasDisponibles.Controls.Clear();

            ancho = (panelRutinasDisponibles.Width / 5);
            alto = (panelRutinasDisponibles.Height / 3);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 4;

            for (int i = 0; i < datos.Count; i++)
            {
                p = new Panel();
                title = new Label();
                costo = new Label();
                cant++;

                byte[] imagen = File.ReadAllBytes("a\\b.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos[i].RutNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.Size = new Size(ancho, 25);
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = datos[i].RutTipoTrenEjer.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.Size = new Size(ancho, 25);
                costo.TabIndex = i;

                p.Controls.Add(title);
                p.Controls.Add(costo);
                title.Location = new Point(0, 5);
                costo.Location = new Point(0, (p.Height - costo.Height));

                panelRutinasDisponibles.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (panelRutinasDisponibles.Controls.Count > 0)
                {
                    posX = posX + ancho + 38;
                }

                if (cant == incrementa)
                {
                    incrementa = incrementa + 4;
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
            vtnRutinas a = new vtnRutinas();
            a.lblNombreProducto.Text = datos[p.TabIndex].RutNombre;
            a.idrutina.Text = datos[p.TabIndex].RutId.ToString();

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
        private void limpiar1()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT * FROM RUTINA INNER JOIN TIENE1 ON rutina.rut_id = tiene1.rut_id WHERE USU_LOGIN = ('" + UserCache.User + "')";
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
                    clsRutina cartel = new clsRutina();

                    cartel.RutNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                    cartel.RutTipoTrenEjer = dataSet.Tables[0].Rows[j].ItemArray[3].ToString();

                    datos2.Add(cartel);
                }
            }
        }

        private void generarProductos1()
        {
            int posX, posY;
            int ancho, alto;

            panelRutinasUsuario.Controls.Clear();

            ancho = (panelRutinasUsuario.Width / 11);
            alto = (panelRutinasUsuario.Height / 2 + 14);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 0;

            for (int i = 0; i < datos2.Count; i++)
            {
                p = new Panel();
                title = new Label();
                costo = new Label();
                cant++;

                byte[] imagen = File.ReadAllBytes("a\\b.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos2[i].RutNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.Size = new Size(ancho, 25);
                title.ForeColor = Color.White;
                title.TabIndex = i;

                costo.Text = datos2[i].RutTipoTrenEjer.ToString();
                costo.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                costo.Size = new Size(ancho, 25);
                costo.TabIndex = i;

                p.Controls.Add(title);
                p.Controls.Add(costo);
                title.Location = new Point(0, 5);
                costo.Location = new Point(0, (p.Height - costo.Height));

                panelRutinasUsuario.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (panelRutinasUsuario.Controls.Count > 0)
                {
                    posX = posX + ancho + 38;
                }

                if (cant == incrementa)
                {
                    incrementa = incrementa + 0;
                    posX = 0;
                    posY = posY + alto + 38;
                }
                p.Click += new EventHandler(cliquear);
            }
        }
    }
}
