using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasBD
{
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            String strNombreProd = txtNombre.Text;
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-LEMH\\SQLEXPRESS; database=Facturacion; Integrated Security= SSPI");
            conexion.Open();
            String strComando = "UPDATE productos SET precio_unit = " + txtPrecio.Text + "WHERE nombre_prod LIKE '" + strNombreProd + "%'";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            int num = comando.ExecuteNonQuery();
            txtAfectacion.Text = num.ToString();
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            String strNombreProd = txtNombre.Text;
            SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-LEMH\\SQLEXPRESS; database=Facturacion; Integrated Security= SSPI");
            conexion.Open();
            String strComando = "UPDATE productos SET unidad += " +txtCantidad.Text+ "WHERE nombre_prod LIKE '" + strNombreProd + "%'";
            SqlCommand comando = new SqlCommand(strComando, conexion);
            int num = comando.ExecuteNonQuery();
            txtActualizacion2.Text = num.ToString();
        }
    }
}
