namespace Proyecto1
{
    public partial class ProyectoBD : Form
    {
        public ProyectoBD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Comprar
        private void buttonComprar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormComprar());
        }
        #endregion 
        #region ConsultarFacturas
        private void buttonConsultarFacturas_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormConsultarFacturas());
        }
        #endregion 
        #region ConsultarStock
        private void buttonConsultarSock_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormInventario());
        }
        #endregion
        #region AcercaDeNosotros
        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new FormSobreNosotros());
        }
        #endregion

        private Form formularioActivo = null;

        private void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(formularioHijo);
            panelFormularioHijo.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}