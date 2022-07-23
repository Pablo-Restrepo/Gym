using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Visual.accesoDatos
{
    class Datos
    {
        //Cadena de Conexion
        String connectionString =
            "Data Source=localhost:1521/xe;User Id=pablo;Password=oracle";
        OracleConnection miConexion = new OracleConnection();

        //Constructor
        public Datos()
        {
            miConexion.ConnectionString = connectionString;
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                miConexion.ConnectionString = connectionString;
                miConexion.Open();
                MessageBox.Show("Se conecto a la base de datos con exito!");
                miConexion.Close();
            }
            catch (Exception ex)
            {
                miConexion.Close();
                MessageBox.Show("Ocurrió un error con la base de datos: " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            miConexion.Close();
        }
    }
}
