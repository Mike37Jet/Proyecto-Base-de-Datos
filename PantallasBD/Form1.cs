using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonSalir_MouseHover(object sender, EventArgs e)
        {
            buttonSalir.BackColor = Color.Bisque;
            
        }

        private void buttonSalir_MouseLeave(object sender, EventArgs e)
        {
            buttonSalir.BackColor = SystemColors.Control;
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            FormInsertar formInsertar = new FormInsertar();
            formInsertar.ShowDialog();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
