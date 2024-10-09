namespace Trabajo3Uni
{
    partial class Productor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productor));
            Nombre = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Ventas = new ListBox();
            Produccion = new ListBox();
            panel6 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            TxtSalario = new TextBox();
            TxtPuesto = new TextBox();
            Name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtDepartamento = new ComboBox();
            panel4 = new Panel();
            Limpiar = new Button();
            button2 = new Button();
            button1 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Font = new Font("Segoe UI Black", 15F);
            Nombre.Location = new Point(515, 23);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(213, 35);
            Nombre.TabIndex = 0;
            Nombre.Text = "Productores S.A";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(Nombre);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 77);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Ventas);
            panel2.Controls.Add(Produccion);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(1202, 243);
            panel2.TabIndex = 2;
            // 
            // Ventas
            // 
            Ventas.BackColor = Color.Pink;
            Ventas.BorderStyle = BorderStyle.FixedSingle;
            Ventas.Cursor = Cursors.No;
            Ventas.Dock = DockStyle.Right;
            Ventas.FormattingEnabled = true;
            Ventas.Location = new Point(580, 0);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(612, 243);
            Ventas.TabIndex = 5;
            // 
            // Produccion
            // 
            Produccion.BackColor = Color.Wheat;
            Produccion.Cursor = Cursors.No;
            Produccion.Dock = DockStyle.Left;
            Produccion.FormattingEnabled = true;
            Produccion.Location = new Point(10, 0);
            Produccion.Name = "Produccion";
            Produccion.Size = new Size(573, 243);
            Produccion.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1192, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 243);
            panel6.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 243);
            panel5.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(TxtSalario);
            panel3.Controls.Add(TxtPuesto);
            panel3.Controls.Add(Name);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(TxtDepartamento);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(1047, 387);
            panel3.TabIndex = 3;
            // 
            // TxtSalario
            // 
            TxtSalario.Cursor = Cursors.IBeam;
            TxtSalario.Location = new Point(328, 268);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(626, 27);
            TxtSalario.TabIndex = 3;
            // 
            // TxtPuesto
            // 
            TxtPuesto.Cursor = Cursors.IBeam;
            TxtPuesto.Location = new Point(328, 108);
            TxtPuesto.Name = "TxtPuesto";
            TxtPuesto.Size = new Size(626, 27);
            TxtPuesto.TabIndex = 3;
            // 
            // Name
            // 
            Name.Cursor = Cursors.IBeam;
            Name.Location = new Point(328, 44);
            Name.Name = "Name";
            Name.Size = new Size(626, 27);
            Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 190);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 2;
            label4.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 271);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Salario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 111);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre y Apellico";
            // 
            // TxtDepartamento
            // 
            TxtDepartamento.Cursor = Cursors.Hand;
            TxtDepartamento.FormattingEnabled = true;
            TxtDepartamento.Items.AddRange(new object[] { "Ventas", "Produccion" });
            TxtDepartamento.Location = new Point(328, 186);
            TxtDepartamento.Name = "TxtDepartamento";
            TxtDepartamento.Size = new Size(400, 28);
            TxtDepartamento.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonShadow;
            panel4.Controls.Add(Limpiar);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Cursor = Cursors.Hand;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(1047, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 387);
            panel4.TabIndex = 4;
            // 
            // Limpiar
            // 
            Limpiar.Cursor = Cursors.Hand;
            Limpiar.Location = new Point(3, 145);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(132, 29);
            Limpiar.TabIndex = 0;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(6, 219);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 0;
            button2.Text = "Mostrar enpleados";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 0;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(1192, 77);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 387);
            panel7.TabIndex = 5;
            // 
            // panel8
            // 
            panel8.BackColor = Color.BlanchedAlmond;
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(1047, 77);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 387);
            panel8.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.trabajadores;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(427, 10);
            panel9.Name = "panel9";
            panel9.Size = new Size(82, 61);
            panel9.TabIndex = 1;
            // 
            // Productor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 707);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Hiragana;
            IsMdiContainer = true;
         //   Name = "Productor";
            Text = "Productora S.A";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Nombre;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button Limpiar;
        private Button button2;
        private ComboBox TxtDepartamento;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtSalario;
        private TextBox TxtPuesto;
        private TextBox Name;
        private Label label4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private ListBox Ventas;
        private ListBox Produccion;
        private Panel panel9;
    }
}
