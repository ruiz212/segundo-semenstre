namespace Proyecto_final
{
    partial class PrestamoLibro
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            cmbTipoUsuario = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F);
            label1.Location = new Point(342, 27);
            label1.Name = "label1";
            label1.Size = new Size(215, 25);
            label1.TabIndex = 0;
            label1.Text = "Sitema de prestamo";
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(cmbTipoUsuario);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 459);
            panel2.TabIndex = 1;
            // 
            // cmbTipoUsuario
            // 
            cmbTipoUsuario.AutoSize = true;
            cmbTipoUsuario.Font = new Font("Segoe UI", 10F);
            cmbTipoUsuario.Location = new Point(386, 20);
            cmbTipoUsuario.Name = "cmbTipoUsuario";
            cmbTipoUsuario.Size = new Size(130, 23);
            cmbTipoUsuario.TabIndex = 0;
            cmbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(286, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 28);
            comboBox1.TabIndex = 1;
            // 
            // PrestamoLibro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 529);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PrestamoLibro";
            Text = "PrestamoLibro";
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
        private Label cmbTipoUsuario;
        private ComboBox comboBox1;
    }
}