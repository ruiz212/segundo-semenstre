namespace Trabajo3Uni
{
    partial class Form1
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
            Nombre = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            Ventas = new ListBox();
            Produccion = new ListBox();
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
            Nombre.Location = new Point(258, 23);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(213, 35);
            Nombre.TabIndex = 0;
            Nombre.Text = "Productores S.A";
            // 
            // panel1
            // 
            panel1.Controls.Add(Nombre);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 77);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Ventas);
            panel2.Controls.Add(Produccion);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 243);
            panel2.TabIndex = 2;
            // 
            // Ventas
            // 
            Ventas.Dock = DockStyle.Right;
            Ventas.FormattingEnabled = true;
            Ventas.Location = new Point(380, 0);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(420, 243);
            Ventas.TabIndex = 1;
            // 
            // Produccion
            // 
            Produccion.Dock = DockStyle.Left;
            Produccion.FormattingEnabled = true;
            Produccion.Location = new Point(0, 0);
            Produccion.Name = "Produccion";
            Produccion.Size = new Size(382, 243);
            Produccion.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
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
            panel3.Size = new Size(617, 387);
            panel3.TabIndex = 3;
            // 
            // TxtSalario
            // 
            TxtSalario.Location = new Point(220, 276);
            TxtSalario.Name = "TxtSalario";
            TxtSalario.Size = new Size(377, 27);
            TxtSalario.TabIndex = 3;
            // 
            // TxtPuesto
            // 
            TxtPuesto.Location = new Point(220, 116);
            TxtPuesto.Name = "TxtPuesto";
            TxtPuesto.Size = new Size(377, 27);
            TxtPuesto.TabIndex = 3;
            // 
            // Name
            // 
            Name.Location = new Point(220, 52);
            Name.Name = "Name";
            Name.Size = new Size(377, 27);
            Name.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 198);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 2;
            label4.Text = "Departamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 279);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Salario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Puesto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 55);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre y Apellico";
            // 
            // TxtDepartamento
            // 
            TxtDepartamento.FormattingEnabled = true;
            TxtDepartamento.Items.AddRange(new object[] { "Ventas", "Produccion" });
            TxtDepartamento.Location = new Point(220, 194);
            TxtDepartamento.Name = "TxtDepartamento";
            TxtDepartamento.Size = new Size(151, 28);
            TxtDepartamento.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(Limpiar);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(617, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 387);
            panel4.TabIndex = 4;
            // 
            // Limpiar
            // 
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
            button1.Location = new Point(3, 56);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 0;
            button1.Text = "Agregar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 707);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
       
            Text = "Form1";
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
        private ListBox Produccion;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private ListBox Ventas;
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
    }
}
