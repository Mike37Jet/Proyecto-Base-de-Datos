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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-LEMH\\SQLEXPRESS ; database=Facturacion; Integrated Security=SSPI");
            String strComm = "SELECT * FROM PRODUCTOS";
            conn.Open();
            SqlCommand comm = new SqlCommand(strComm, conn);
            SqlDataReader lectorFilas = comm.ExecuteReader();
            if (lectorFilas != null )
            {
                while(lectorFilas.Read())
                {
                    this.lstProductos.Items.Add(lectorFilas.GetString(1));
                }
                return;
            }
            
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.nombreProducto = this.txtNombre.Text;
            //here's you gonna change DATA SOURCE for your sql base direction
            this.strConexion = "Data Source=LAPTOP-LEMH\\SQLEXPRESS ; database=Facturacion; Integrated Security=SSPI";
            using (this.conexion = new System.Data.SqlClient.SqlConnection(this.strConexion)) {
                conexion.Open();//here's the conexion with data base
                strComando = "DELETE FROM Productos WHERE nombre_prod LIKE '" + this.txtNombre + "%';";
                using (this.comando = new System.Data.SqlClient.SqlCommand(strComando, conexion)) { 
                    int numero = this.comando.ExecuteNonQuery();
                    this.txtResultado.Text = numero.ToString();
                }

            }
            
        }
    }
}
