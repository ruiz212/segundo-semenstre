namespace ProyectoPropuesto
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
            label1 = new Label();
            combVehiculoTipo = new ComboBox();
            txtModelo = new TextBox();
            dtAño = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            grpElectric = new GroupBox();
            txtCapasidad = new TextBox();
            lblCapasidad = new Label();
            grpHibridoComponete = new GroupBox();
            txtBateriaCapasidad = new TextBox();
            txtCilindrada = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtVelocidadMaxima = new TextBox();
            lblVelosidadMaxima = new Label();
            lblTipoCombustible = new Label();
            btnCalcular = new Button();
            grpElectric.SuspendLayout();
            grpHibridoComponete.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 35);
            label1.TabIndex = 0;
            label1.Text = "Sistema de control vehicular";
            // 
            // combVehiculoTipo
            // 
            combVehiculoTipo.AccessibleDescription = "";
            combVehiculoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            combVehiculoTipo.FormattingEnabled = true;
            combVehiculoTipo.Items.AddRange(new object[] { "Electrico", "Gasolina", "Hibrido" });
            combVehiculoTipo.Location = new Point(63, 101);
            combVehiculoTipo.Name = "combVehiculoTipo";
            combVehiculoTipo.Size = new Size(263, 28);
            combVehiculoTipo.TabIndex = 1;
            combVehiculoTipo.SelectedIndexChanged += combVehiculoTipo_SelectedIndexChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(373, 102);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(234, 27);
            txtModelo.TabIndex = 2;
            // 
            // dtAño
            // 
            dtAño.Format = DateTimePickerFormat.Short;
            dtAño.Location = new Point(654, 102);
            dtAño.MaxDate = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            dtAño.Name = "dtAño";
            dtAño.Size = new Size(250, 27);
            dtAño.TabIndex = 3;
            dtAño.Value = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(443, 71);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 4;
            label2.Tag = "Modelo";
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(764, 71);
            label3.Name = "label3";
            label3.Size = new Size(48, 28);
            label3.TabIndex = 4;
            label3.Tag = "Modelo";
            label3.Text = "Año";
            // 
            // grpElectric
            // 
            grpElectric.Controls.Add(txtCapasidad);
            grpElectric.Controls.Add(lblCapasidad);
            grpElectric.Location = new Point(12, 194);
            grpElectric.Name = "grpElectric";
            grpElectric.Size = new Size(363, 180);
            grpElectric.TabIndex = 5;
            grpElectric.TabStop = false;
            grpElectric.Visible = false;
            // 
            // txtCapasidad
            // 
            txtCapasidad.Location = new Point(78, 90);
            txtCapasidad.Name = "txtCapasidad";
            txtCapasidad.Size = new Size(168, 27);
            txtCapasidad.TabIndex = 7;
            // 
            // lblCapasidad
            // 
            lblCapasidad.AutoSize = true;
            lblCapasidad.Font = new Font("Segoe UI", 12F);
            lblCapasidad.Location = new Point(50, 23);
            lblCapasidad.Name = "lblCapasidad";
            lblCapasidad.Size = new Size(196, 28);
            lblCapasidad.TabIndex = 6;
            lblCapasidad.Text = "Capasidad de bateria";
            // 
            // grpHibridoComponete
            // 
            grpHibridoComponete.Controls.Add(txtBateriaCapasidad);
            grpHibridoComponete.Controls.Add(txtCilindrada);
            grpHibridoComponete.Controls.Add(label6);
            grpHibridoComponete.Controls.Add(label5);
            grpHibridoComponete.Location = new Point(403, 194);
            grpHibridoComponete.Name = "grpHibridoComponete";
            grpHibridoComponete.Size = new Size(432, 180);
            grpHibridoComponete.TabIndex = 5;
            grpHibridoComponete.TabStop = false;
            grpHibridoComponete.Visible = false;
            // 
            // txtBateriaCapasidad
            // 
            txtBateriaCapasidad.Location = new Point(188, 95);
            txtBateriaCapasidad.Name = "txtBateriaCapasidad";
            txtBateriaCapasidad.Size = new Size(185, 27);
            txtBateriaCapasidad.TabIndex = 7;
            // 
            // txtCilindrada
            // 
            txtCilindrada.Location = new Point(28, 95);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(124, 27);
            txtCilindrada.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(40, 51);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 6;
            label6.Text = "Cilindrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(177, 51);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 6;
            label5.Text = "Capasidad de bateria";
            // 
            // txtVelocidadMaxima
            // 
            txtVelocidadMaxima.Location = new Point(90, 482);
            txtVelocidadMaxima.Name = "txtVelocidadMaxima";
            txtVelocidadMaxima.Size = new Size(168, 27);
            txtVelocidadMaxima.TabIndex = 7;
            // 
            // lblVelosidadMaxima
            // 
            lblVelosidadMaxima.AutoSize = true;
            lblVelosidadMaxima.Font = new Font("Segoe UI", 12F);
            lblVelosidadMaxima.Location = new Point(63, 403);
            lblVelosidadMaxima.Name = "lblVelosidadMaxima";
            lblVelosidadMaxima.Size = new Size(196, 28);
            lblVelosidadMaxima.TabIndex = 6;
            lblVelosidadMaxima.Text = "Capasidad de bateria";
            // 
            // lblTipoCombustible
            // 
            lblTipoCombustible.AutoSize = true;
            lblTipoCombustible.Font = new Font("Segoe UI", 12F);
            lblTipoCombustible.Location = new Point(431, 481);
            lblTipoCombustible.Name = "lblTipoCombustible";
            lblTipoCombustible.Size = new Size(191, 28);
            lblTipoCombustible.TabIndex = 6;
            lblTipoCombustible.Text = "Tipo de combustible";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(752, 469);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(140, 52);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 634);
            Controls.Add(btnCalcular);
            Controls.Add(txtVelocidadMaxima);
            Controls.Add(lblVelosidadMaxima);
            Controls.Add(lblTipoCombustible);
            Controls.Add(grpHibridoComponete);
            Controls.Add(grpElectric);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtAño);
            Controls.Add(txtModelo);
            Controls.Add(combVehiculoTipo);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MainForm";
            grpElectric.ResumeLayout(false);
            grpElectric.PerformLayout();
            grpHibridoComponete.ResumeLayout(false);
            grpHibridoComponete.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox combVehiculoTipo;
        private TextBox txtModelo;
        private DateTimePicker dtAño;
        private Label label2;
        private Label label3;
        private GroupBox grpElectric;
        private TextBox txtCapasidad;
        private Label lblCapasidad;
        private GroupBox grpHibridoComponete;
        private TextBox txtBateriaCapasidad;
        private TextBox txtCilindrada;
        private Label label6;
        private Label label5;
        private TextBox txtVelocidadMaxima;
        private Label lblVelosidadMaxima;
        private Label lblTipoCombustible;
        private Button btnCalcular;
    }
}
