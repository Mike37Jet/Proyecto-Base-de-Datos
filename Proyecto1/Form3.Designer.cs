namespace Proyecto1
{
    partial class FormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSalir = new Button();
            panelTitulo = new Panel();
            label1 = new Label();
            btnConsultar = new Button();
            istInventario = new ListBox();
            textBox1 = new TextBox();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(504, 339);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Regresar";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.LightSteelBlue;
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(3, 2, 3, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(597, 52);
            panelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 14);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            label1.Click += label1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.DarkCyan;
            btnConsultar.BackgroundImageLayout = ImageLayout.Center;
            btnConsultar.FlatStyle = FlatStyle.Popup;
            btnConsultar.Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.ButtonHighlight;
            btnConsultar.Location = new Point(77, 92);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(130, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar Stock";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // istInventario
            // 
            istInventario.BackColor = SystemColors.Info;
            istInventario.BorderStyle = BorderStyle.FixedSingle;
            istInventario.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            istInventario.FormattingEnabled = true;
            istInventario.ItemHeight = 22;
            istInventario.Location = new Point(231, 135);
            istInventario.Name = "istInventario";
            istInventario.Size = new Size(213, 200);
            istInventario.TabIndex = 3;
            istInventario.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "ingrese el nombre del ítem";
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(597, 370);
            Controls.Add(textBox1);
            Controls.Add(istInventario);
            Controls.Add(btnConsultar);
            Controls.Add(panelTitulo);
            Controls.Add(buttonSalir);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInventario";
            Text = "Form Inventario";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Panel panelTitulo;
        private Label label1;
        private Button btnConsultar;
        private ListBox istInventario;
        private TextBox textBox1;
    }
}