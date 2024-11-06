namespace Proyecto_final
{
    partial class AgregarLibro
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            bntAgregarLibro = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtAñoPublicacion = new TextBox();
            txtEditorial = new TextBox();
            lblIsbn = new Label();
            label5 = new Label();
            txtAutor = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bntAgregarLibro);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 82);
            panel1.TabIndex = 0;
            // 
            // bntAgregarLibro
            // 
            bntAgregarLibro.Location = new Point(867, 22);
            bntAgregarLibro.Name = "bntAgregarLibro";
            bntAgregarLibro.Size = new Size(124, 34);
            bntAgregarLibro.TabIndex = 2;
            bntAgregarLibro.Text = "Agregar libro";
            bntAgregarLibro.UseVisualStyleBackColor = true;
            bntAgregarLibro.Click += bntAgregarLibro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(403, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "Agregar libro";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtAñoPublicacion);
            panel2.Controls.Add(txtEditorial);
            panel2.Controls.Add(lblIsbn);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAutor);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 471);
            panel2.TabIndex = 1;
            // 
            // txtAñoPublicacion
            // 
            txtAñoPublicacion.Location = new Point(152, 343);
            txtAñoPublicacion.Name = "txtAñoPublicacion";
            txtAñoPublicacion.Size = new Size(332, 27);
            txtAñoPublicacion.TabIndex = 1;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(543, 234);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(332, 27);
            txtEditorial.TabIndex = 1;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 10F);
            lblIsbn.Location = new Point(152, 234);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(114, 23);
            lblIsbn.TabIndex = 0;
            lblIsbn.Text = "Codigo Unico";
            lblIsbn.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(152, 292);
            label5.Name = "label5";
            label5.Size = new Size(157, 23);
            label5.TabIndex = 0;
            label5.Text = "Año de Publicacion";
            label5.Click += label1_Click;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(543, 138);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(332, 27);
            txtAutor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(543, 192);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 0;
            label4.Text = "Editorial";
            label4.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(543, 100);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 0;
            label3.Text = "Autor";
            label3.Click += label1_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(152, 138);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(332, 27);
            txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(152, 100);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 0;
            label2.Text = "Titulo";
            label2.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AgregarLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarLibro";
            Text = "AgregarLibro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtTitulo;
        private TextBox txtEditorial;
        private Label lblIsbn;
        private TextBox txtAutor;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox txtAñoPublicacion;
        private Label label5;
        private Button bntAgregarLibro;
    }
}