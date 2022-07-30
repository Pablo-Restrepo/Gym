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
    public partial class vtnAlimentacion : Form
    {
        String connectionString = UserCache.conexion;
        List<clsPlanAlimentacion> datos = new List<clsPlanAlimentacion>();
        List<clsPlanAlimentacion> datos2 = new List<clsPlanAlimentacion>();
        MemoryStream ms = new MemoryStream();
        Panel p = new Panel();
        Label title = new Label();
        public vtnAlimentacion()
        {
            InitializeComponent();
        }

        private void vtnAlimentacion_Load(object sender, EventArgs e)
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
            string sql = "SELECT * FROM PLANALIMENTACION";
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
                    clsPlanAlimentacion cartel = new clsPlanAlimentacion();

                    cartel.PlanNombre = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                    cartel.PlanId = Int32.Parse(dataSet.Tables[0].Rows[j].ItemArray[0].ToString());

                    datos.Add(cartel);
                }
            }
        }

        private void generarProductos()
        {
            int posX, posY;
            int ancho, alto;

            panelAliDisponibles.Controls.Clear();

            ancho = (panelAliDisponibles.Width / 5);
            alto = (panelAliDisponibles.Height / 3);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 4;

            for (int i = 0; i < datos.Count; i++)
            {
                p = new Panel();
                title = new Label();
                cant++;

                byte[] imagen = File.ReadAllBytes("a\\b.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos[i].PlanNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.Size = new Size(ancho, 25);
                title.ForeColor = Color.White;
                title.TabIndex = i;

                p.Controls.Add(title);
                title.Location = new Point(0, 5);

                panelAliDisponibles.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (panelAliDisponibles.Controls.Count > 0)
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
            OracleConnection miConexion = new OracleConnection();
            miConexion.ConnectionString = connectionString;
            miConexion.Open();
            string sql = "SELECT plan_lunes \"Lunes\" , plan_martes \"Martes\", plan_miercoles \"Miercoles\", plan_jueves \"Jueves\", plan_viernes \"Viernes\", plan_sabado \"Sabado\", plan_domingo \"Domingo\" FROM planalimentacion";
            OracleCommand sqlSelect = new OracleCommand(sql);
            sqlSelect.Connection = miConexion;
            var dr = sqlSelect.ExecuteReader();
            vtnPlanAlimentacion a = new vtnPlanAlimentacion();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(dr);
            a.dataGridView1.DataSource = dt;
            a.lblNombrePlan.Text = datos[p.TabIndex].PlanNombre.ToString();
            a.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            a.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            a.label2.Text = datos[p.TabIndex].PlanId.ToString();

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
            string sql = "SELECT * FROM PLANALIMENTACION INNER JOIN ASIGNA ON PLANALIMENTACION.PLAN_ID = ASIGNA.PLAN_ID WHERE USU_LOGIN = ('" + UserCache.User + "')";
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
                    clsPlanAlimentacion cartel = new clsPlanAlimentacion();

                    cartel.PlanNombre = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();

                    datos2.Add(cartel);
                }
            }
        }

        private void generarProductos1()
        {
            int posX, posY;
            int ancho, alto;

            panelAliUsuario.Controls.Clear();

            ancho = (panelAliUsuario.Width / 11);
            alto = (panelAliUsuario.Height / 2 + 14);
            posX = 0;
            posY = 0;

            int cant = 0;
            int incrementa = 0;

            for (int i = 0; i < datos2.Count; i++)
            {
                p = new Panel();
                title = new Label();
                cant++;

                byte[] imagen = File.ReadAllBytes("a\\b.png");
                ms = new MemoryStream(imagen);
                p.BackgroundImage = Image.FromStream(ms);
                p.BackgroundImageLayout = ImageLayout.Stretch;
                p.TabIndex = i;
                p.Size = new Size(ancho, alto);
                p.Cursor = Cursors.Hand;

                title.Text = datos2[i].PlanNombre;
                title.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                title.Size = new Size(ancho, 25);
                title.ForeColor = Color.White;
                title.TabIndex = i;

                p.Controls.Add(title);
                title.Location = new Point(0, 5);

                panelAliUsuario.Controls.Add(p);
                p.Location = new Point(posX, posY);

                if (panelAliUsuario.Controls.Count > 0)
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
