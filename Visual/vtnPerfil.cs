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
using Visual.modelo;

namespace Visual
{
    public partial class vtnPerfil : Form
    {
        List<clsCliente> datos = new List<clsCliente>();
        List<clsUsuario> datosp = new List<clsUsuario>();
        List<clsExamenMedico> datose = new List<clsExamenMedico>();
        List<clsSuscripcion> datoss = new List<clsSuscripcion>();
        String connectionString = UserCache.conexion;
        public vtnPerfil()
        {
            InitializeComponent();
        }

        private void vtnProteinas_Load(object sender, EventArgs e)
        {
            infoUser();
            comproSuscrip();
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

        private void btnMedico_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "UPDATE USUARIO SET EXA_NOMBRE = 'Examen General' WHERE USU_LOGIN = '" + UserCache.User + "'";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                int inserto = sqlInsert.ExecuteNonQuery();
                if (inserto > 0)
                {
                    MessageBox.Show("Examen medico realizado!");
                    lblExamenMed.Text = "Ex. Medico: Examen General";
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "DELETE FROM COMPRA WHERE USU_LOGIN = '" + UserCache.User + "'";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                int inserto = sqlInsert.ExecuteNonQuery();
                if (inserto > 0)
                {
                    MessageBox.Show("Suscripcion cancelada!");
                }
                else
                {
                    MessageBox.Show("No tienes una Suscripcion!");
                }
                miConexion.Close();
                comproSuscrip();
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void infoUser()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "SELECT * FROM cliente inner join usuario on usuario.per_cedula = cliente.per_cedula where usuario.USU_LOGIN = '" + UserCache.User + "'";
                OracleCommand sqlSelect = new OracleCommand(sql);
                sqlSelect.Connection = miConexion;
                int inserto = sqlSelect.ExecuteNonQuery();
                if (inserto > 0)
                {
                    MessageBox.Show("Comprado!");
                }
                miConexion.Close();

                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlSelect;
                    dataAdapter.Fill(dataSet);
                }

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    clsCliente cartel = new clsCliente();
                    clsUsuario cartelp = new clsUsuario();
                    clsExamenMedico cartele = new clsExamenMedico();

                    for (int j = 0; j < dataSet.Tables[0].Rows.Count; j++)
                    {
                        

                        cartel.PerNombre = dataSet.Tables[0].Rows[j].ItemArray[2].ToString();
                        cartel.PerApellido = dataSet.Tables[0].Rows[j].ItemArray[3].ToString();
                        cartel.PerSexo = dataSet.Tables[0].Rows[j].ItemArray[5].ToString();
                        cartel.CliCiudad = dataSet.Tables[0].Rows[j].ItemArray[10].ToString();

                        datos.Add(cartel);

                        

                        cartelp.usuLogin = dataSet.Tables[0].Rows[j].ItemArray[1].ToString();
                        cartelp.UsuCorreo = dataSet.Tables[0].Rows[j].ItemArray[15].ToString();

                        datosp.Add(cartelp);

                        

                        cartele.Exa_nombre = dataSet.Tables[0].Rows[j].ItemArray[12].ToString();

                        datose.Add(cartele);

                    }
                    lblNombre.Text = "Nombre: " + cartel.PerNombre + " " + cartel.PerApellido;
                    lblSexo.Text = "Sexo: " + cartel.PerSexo;
                    lblCiudad.Text = "Ciudad: " + cartel.CliCiudad;
                    lblUser.Text = "Usuario: " + cartelp.usuLogin;
                    lblCorreo.Text = "Correo: " + cartelp.UsuCorreo;
                    if (cartele.Exa_nombre.Equals(""))
                    {
                        lblExamenMed.Text = "Ex. Medico: No realizado";
                    }
                    else
                    {
                        lblExamenMed.Text = "Ex. Medico: " + cartele.Exa_nombre;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        private void comproSuscrip()
        {
            DataSet dataSet = new DataSet();
            OracleConnection miConexion = new OracleConnection();
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                string sql = "";
                sql = "SELECT USU_LOGIN,SUS_NOMBRE FROM compra WHERE usu_login = '" + UserCache.User + "'";
                OracleCommand sqlInsert = new OracleCommand(sql);
                sqlInsert.Connection = miConexion;
                int inserto = sqlInsert.ExecuteNonQuery();
                using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                {
                    dataAdapter.SelectCommand = sqlInsert;
                    dataAdapter.Fill(dataSet);
                }
                if (!dataSet.Tables[0].Rows[0].ItemArray[0].ToString().Equals(""))
                {
                    lblSuscripEstado.Text = "Suscripcion: Activada";
                }
                miConexion.Close();
            }
            catch (Exception ex)
            {
                lblSuscripEstado.Text = "Suscripcion: Desactivada";
                miConexion.Close();
            }
            
        }
    }
}
