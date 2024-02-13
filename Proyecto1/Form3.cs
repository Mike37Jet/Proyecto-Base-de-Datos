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

namespace Proyecto1
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private String texto = "";
        private String strConsulta= "";
        private SqlCommand commando = null;


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.istInventario.Items.Clear();
            //obtener el texto del text box
            this.texto = this.textBox1.Text;
            //conexion a base de datos
            SqlConnection conexión = new SqlConnection("Data Source=LAPTOP-LEMH\\SQLEXPRESS;database=Facturacion;Integrated Security=SSPI");
            conexión.Open();
            //realizar una consulta 
            this.strConsulta = "SELECT nombre_prod, unidad FROM productos WHERE nombre_prod LIKE '"+ texto +"%'";
            this.commando = new SqlCommand(strConsulta,conexión);
            SqlDataReader lectorFilas = this.commando.ExecuteReader();
            if (lectorFilas != null) {
                while (lectorFilas.Read()) { 
                    istInventario.Items.Add(lectorFilas.GetString(1));
                }
                return;
            }
            istInventario.Items.Add("NO HAY EL PRODUCTO");
        }
    }
}
