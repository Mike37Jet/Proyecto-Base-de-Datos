using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PantallasBD
{
    public partial class FormInsertar : Form
    {
        public FormInsertar()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string strConn = null;
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;

       
    

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String codigo = this.txtCodigo.Text;
            String nombre = "'" + this.txtNombre.Text + "'";
            String precio = this.txtPrecio.Text;
            String unidad = this.txtUnidad.Text;
            String idTipo = this.txtIdTipo.Text;
            String idProveedor = this.txtIdProveedor.Text;
           

           strConn = "Data Source=1-20-03-E004-03; database=Facturacion; Integrated Security=SSPI";
           using(conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "INSERT INTO Productos VALUES(" + codigo +","+nombre+","+precio+","+unidad+","+idTipo+","+idProveedor+")";
                using(comm = new SqlCommand(strComm, conn)) 
                 { 
                    int num = comm.ExecuteNonQuery();
                    txtN.Text = num.ToString();
                 }
            }


        }
    }
}
