namespace Proyecto1
{
    partial class FormSobreNosotros
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
            textBox1 = new TextBox();
            panelTitulo = new Panel();
            label1 = new Label();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalir.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(576, 452);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Regresar";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 125);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 285);
            textBox1.TabIndex = 4;
            textBox1.Text = "INTEGRANTES:\r\nSebastián Haro\r\nEmilio Jácome\r\nMiguel Mendosa\r\nMichael Trocellier\r\n";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.LightSteelBlue;
            panelTitulo.Controls.Add(label1);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(682, 70);
            panelTitulo.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 20);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 1;
            label1.Text = "SOBRE NOSOTROS";
            // 
            // FormSobreNosotros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(682, 493);
            Controls.Add(panelTitulo);
            Controls.Add(textBox1);
            Controls.Add(buttonSalir);
            Name = "FormSobreNosotros";
            Text = "Form Sobre Nosotros";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private TextBox textBox1;
        private Panel panelTitulo;
        private Label label1;
    }
}