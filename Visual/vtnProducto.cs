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
    public partial class vtnProducto : Form
    {

        String connectionString = "Data Source=localhost:1521/xe;User Id=pablo;Password=oracle";

        public vtnProducto()
        {
            InitializeComponent();
        }

        private void vtnProteinas_Load(object sender, EventArgs e)
        {

        }

    }
}
