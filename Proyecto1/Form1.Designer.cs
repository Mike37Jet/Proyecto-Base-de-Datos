﻿namespace Proyecto1
{
    partial class FormComprar
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
            panelTitulo.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(682, 70);
            panelTitulo.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 18);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 0;
            label1.Text = "COMPRAR";
            label1.Click += label1_Click;
            // 
            // FormComprar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(682, 493);
            Controls.Add(panelTitulo);
            Controls.Add(buttonSalir);
            Name = "FormComprar";
            Text = "Form Comprar";
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonSalir;
        private Panel panelTitulo;
        private Label label1;
    }
}