

namespace Proyecto1
{
    partial class ProyectoBD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoBD));
            panelMenuLateral = new Panel();
            buttonSalir = new Button();
            buttonAcercaDe = new Button();
            buttonConsultarSock = new Button();
            buttonConsultarFacturas = new Button();
            buttonComprar = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            panelFormularioHijo = new Panel();
            pictureBox1 = new PictureBox();
            panelMenuLateral.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelFormularioHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(64, 64, 64);
            panelMenuLateral.Controls.Add(buttonSalir);
            panelMenuLateral.Controls.Add(buttonAcercaDe);
            panelMenuLateral.Controls.Add(buttonConsultarSock);
            panelMenuLateral.Controls.Add(buttonConsultarFacturas);
            panelMenuLateral.Controls.Add(buttonComprar);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 564);
            panelMenuLateral.TabIndex = 0;
            // 
            // buttonSalir
            // 
            buttonSalir.Dock = DockStyle.Bottom;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = Color.White;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(0, 489);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Padding = new Padding(5, 0, 0, 0);
            buttonSalir.Size = new Size(250, 75);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.TextAlign = ContentAlignment.MiddleLeft;
            buttonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonAcercaDe
            // 
            buttonAcercaDe.Dock = DockStyle.Top;
            buttonAcercaDe.FlatAppearance.BorderSize = 0;
            buttonAcercaDe.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonAcercaDe.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonAcercaDe.FlatStyle = FlatStyle.Flat;
            buttonAcercaDe.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAcercaDe.ForeColor = Color.White;
            buttonAcercaDe.Image = (Image)resources.GetObject("buttonAcercaDe.Image");
            buttonAcercaDe.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAcercaDe.Location = new Point(0, 350);
            buttonAcercaDe.Name = "buttonAcercaDe";
            buttonAcercaDe.Padding = new Padding(5, 0, 0, 0);
            buttonAcercaDe.Size = new Size(250, 75);
            buttonAcercaDe.TabIndex = 4;
            buttonAcercaDe.Text = "Acerca de nosotros";
            buttonAcercaDe.TextAlign = ContentAlignment.MiddleLeft;
            buttonAcercaDe.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAcercaDe.UseVisualStyleBackColor = true;
            buttonAcercaDe.Click += buttonAcercaDe_Click;
            // 
            // buttonConsultarSock
            // 
            buttonConsultarSock.Dock = DockStyle.Top;
            buttonConsultarSock.FlatAppearance.BorderSize = 0;
            buttonConsultarSock.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonConsultarSock.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonConsultarSock.FlatStyle = FlatStyle.Flat;
            buttonConsultarSock.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConsultarSock.ForeColor = Color.White;
            buttonConsultarSock.Image = (Image)resources.GetObject("buttonConsultarSock.Image");
            buttonConsultarSock.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarSock.Location = new Point(0, 275);
            buttonConsultarSock.Name = "buttonConsultarSock";
            buttonConsultarSock.Padding = new Padding(5, 0, 0, 0);
            buttonConsultarSock.Size = new Size(250, 75);
            buttonConsultarSock.TabIndex = 3;
            buttonConsultarSock.Text = "Consultar Stock Producto";
            buttonConsultarSock.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultarSock.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsultarSock.UseVisualStyleBackColor = true;
            buttonConsultarSock.Click += buttonConsultarSock_Click;
            // 
            // buttonConsultarFacturas
            // 
            buttonConsultarFacturas.Dock = DockStyle.Top;
            buttonConsultarFacturas.FlatAppearance.BorderSize = 0;
            buttonConsultarFacturas.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonConsultarFacturas.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonConsultarFacturas.FlatStyle = FlatStyle.Flat;
            buttonConsultarFacturas.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConsultarFacturas.ForeColor = Color.White;
            buttonConsultarFacturas.Image = (Image)resources.GetObject("buttonConsultarFacturas.Image");
            buttonConsultarFacturas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonConsultarFacturas.Location = new Point(0, 200);
            buttonConsultarFacturas.Name = "buttonConsultarFacturas";
            buttonConsultarFacturas.Padding = new Padding(5, 0, 0, 0);
            buttonConsultarFacturas.Size = new Size(250, 75);
            buttonConsultarFacturas.TabIndex = 2;
            buttonConsultarFacturas.Text = "Consultar Facturas";
            buttonConsultarFacturas.TextAlign = ContentAlignment.MiddleLeft;
            buttonConsultarFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonConsultarFacturas.UseVisualStyleBackColor = true;
            buttonConsultarFacturas.Click += buttonConsultarFacturas_Click;
            // 
            // buttonComprar
            // 
            buttonComprar.Dock = DockStyle.Top;
            buttonComprar.FlatAppearance.BorderSize = 0;
            buttonComprar.FlatAppearance.MouseDownBackColor = Color.Gray;
            buttonComprar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            buttonComprar.FlatStyle = FlatStyle.Flat;
            buttonComprar.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComprar.ForeColor = Color.White;
            buttonComprar.Image = (Image)resources.GetObject("buttonComprar.Image");
            buttonComprar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonComprar.Location = new Point(0, 125);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Padding = new Padding(5, 0, 0, 0);
            buttonComprar.Size = new Size(250, 75);
            buttonComprar.TabIndex = 1;
            buttonComprar.Text = "Comprar";
            buttonComprar.TextAlign = ContentAlignment.MiddleLeft;
            buttonComprar.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.LightSteelBlue;
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 125);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.BackColor = SystemColors.ControlLight;
            panelFormularioHijo.Controls.Add(pictureBox1);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(250, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(738, 564);
            panelFormularioHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProyectoBD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(988, 564);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenuLateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 540);
            Name = "ProyectoBD";
            Text = "Proyecto Base de Datos";
            TransparencyKey = Color.Chocolate;
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelFormularioHijo.ResumeLayout(false);
            panelFormularioHijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion

        private Panel panelMenuLateral;
        private Button buttonComprar;
        private Panel panelLogo;
        private Button buttonConsultarSock;
        private Button buttonConsultarFacturas;
        private Button buttonAcercaDe;
        private Panel panelFormularioHijo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonSalir;
    }
}
