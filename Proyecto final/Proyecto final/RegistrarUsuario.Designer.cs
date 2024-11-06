namespace Proyecto_final
{
    partial class RegistrarUsuario
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
            txtNumeroDeTrabajador = new TextBox();
            lblCarnet = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtCarrera = new TextBox();
            label2 = new Label();
            cmbTipoUsuario = new ComboBox();
            grpUserEstudiante = new GroupBox();
            label5 = new Label();
            txtNumeroCarnet = new TextBox();
            grpUserMaestro = new GroupBox();
            txtNombreApellidoDeTrabajador = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAreaConocimientoTrabajador = new TextBox();
            label4 = new Label();
            btnAgregarUsuario = new Button();
            grpUserEstudiante.SuspendLayout();
            grpUserMaestro.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumeroDeTrabajador
            // 
            txtNumeroDeTrabajador.Location = new Point(19, 65);
            txtNumeroDeTrabajador.Name = "txtNumeroDeTrabajador";
            txtNumeroDeTrabajador.Size = new Size(200, 34);
            txtNumeroDeTrabajador.TabIndex = 0;
            // 
            // lblCarnet
            // 
            lblCarnet.AutoSize = true;
            lblCarnet.Font = new Font("Segoe UI", 9F);
            lblCarnet.Location = new Point(23, 33);
            lblCarnet.Name = "lblCarnet";
            lblCarnet.Size = new Size(102, 20);
            lblCarnet.TabIndex = 1;
            lblCarnet.Text = "N° Trabajador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 118);
            label1.Name = "label1";
            label1.Size = new Size(176, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre y apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(23, 251);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(278, 34);
            txtCarrera.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 213);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Carrera";
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoUsuario.FormattingEnabled = true;
            cmbTipoUsuario.Items.AddRange(new object[] { "Alumno", "Maestro" });
            cmbTipoUsuario.Location = new Point(291, 55);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(266, 28);
            cmbTipoUsuario.TabIndex = 2;
            cmbTipoUsuario.SelectedIndexChanged += Dinamismo;
            // 
            // grpUserEstudiante
            // 
            grpUserEstudiante.Controls.Add(label5);
            grpUserEstudiante.Controls.Add(txtNumeroCarnet);
            grpUserEstudiante.Controls.Add(txtNombre);
            grpUserEstudiante.Controls.Add(label2);
            grpUserEstudiante.Controls.Add(txtCarrera);
            grpUserEstudiante.Controls.Add(label1);
            grpUserEstudiante.Font = new Font("Segoe UI", 12F);
            grpUserEstudiante.Location = new Point(69, 134);
            grpUserEstudiante.Name = "grpUserEstudiante";
            grpUserEstudiante.Size = new Size(342, 342);
            grpUserEstudiante.TabIndex = 3;
            grpUserEstudiante.TabStop = false;
            grpUserEstudiante.Text = "Estudiante ";
            grpUserEstudiante.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(27, 49);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 1;
            label5.Text = "N° Carnet";
            // 
            // txtNumeroCarnet
            // 
            txtNumeroCarnet.Location = new Point(23, 81);
            txtNumeroCarnet.Name = "txtNumeroCarnet";
            txtNumeroCarnet.Size = new Size(200, 34);
            txtNumeroCarnet.TabIndex = 0;
            // 
            // grpUserMaestro
            // 
            grpUserMaestro.Controls.Add(lblCarnet);
            grpUserMaestro.Controls.Add(txtNumeroDeTrabajador);
            grpUserMaestro.Controls.Add(txtNombreApellidoDeTrabajador);
            grpUserMaestro.Controls.Add(label6);
            grpUserMaestro.Controls.Add(label7);
            grpUserMaestro.Controls.Add(txtAreaConocimientoTrabajador);
            grpUserMaestro.Font = new Font("Segoe UI", 12F);
            grpUserMaestro.Location = new Point(475, 134);
            grpUserMaestro.Name = "grpUserMaestro";
            grpUserMaestro.Size = new Size(342, 342);
            grpUserMaestro.TabIndex = 3;
            grpUserMaestro.TabStop = false;
            grpUserMaestro.Text = "Maestro";
            grpUserMaestro.Visible = false;
            // 
            // txtNombreApellidoDeTrabajador
            // 
            txtNombreApellidoDeTrabajador.Location = new Point(19, 155);
            txtNombreApellidoDeTrabajador.Name = "txtNombreApellidoDeTrabajador";
            txtNombreApellidoDeTrabajador.Size = new Size(318, 34);
            txtNombreApellidoDeTrabajador.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 112);
            label6.Name = "label6";
            label6.Size = new Size(176, 28);
            label6.TabIndex = 1;
            label6.Text = "Nombre y apellido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 200);
            label7.Name = "label7";
            label7.Size = new Size(203, 28);
            label7.TabIndex = 1;
            label7.Text = "Area de conosimiento";
            // 
            // txtAreaConocimientoTrabajador
            // 
            txtAreaConocimientoTrabajador.Location = new Point(19, 231);
            txtAreaConocimientoTrabajador.Name = "txtAreaConocimientoTrabajador";
            txtAreaConocimientoTrabajador.Size = new Size(278, 34);
            txtAreaConocimientoTrabajador.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(343, 13);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 4;
            label4.Text = "Tipo de usuario";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(695, 55);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(144, 29);
            btnAgregarUsuario.TabIndex = 5;
            btnAgregarUsuario.Text = "Agregar Usurario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += AgregarUsuario;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 611);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(label4);
            Controls.Add(cmbTipoUsuario);
            Controls.Add(grpUserMaestro);
            Controls.Add(grpUserEstudiante);
            Name = "RegistrarUsuario";
            Text = "RegistrarUsuario";
            Load += RegistrarUsuario_Load;
            grpUserEstudiante.ResumeLayout(false);
            grpUserEstudiante.PerformLayout();
            grpUserMaestro.ResumeLayout(false);
            grpUserMaestro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroDeTrabajador;
        private Label lblCarnet;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCarrera;
        private Label label2;
        private ComboBox cmbTipoUsuario;
        private GroupBox grpUserEstudiante;
        private GroupBox grpUserMaestro;
        private Label label4;
        private Label label5;
        private TextBox txtNumeroCarnet;
        private TextBox txtNombreApellidoDeTrabajador;
        private Label label6;
        private Label label7;
        private TextBox txtAreaConocimientoTrabajador;
        private Button btnAgregarUsuario;
    }
}