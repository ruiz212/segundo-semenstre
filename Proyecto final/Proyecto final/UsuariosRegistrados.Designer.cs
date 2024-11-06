namespace Proyecto_final
{
    partial class UsuariosRegistrados
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
            label1 = new Label();
            dataGridUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(385, 26);
            label1.Name = "label1";
            label1.Size = new Size(232, 35);
            label1.TabIndex = 0;
            label1.Text = "Usuarios registrado";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(1, 74);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersWidth = 51;
            dataGridUsuarios.Size = new Size(1025, 470);
            dataGridUsuarios.TabIndex = 1;
            // 
            // UsuariosRegistrados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 542);
            Controls.Add(dataGridUsuarios);
            Controls.Add(label1);
            Name = "UsuariosRegistrados";
            Text = "UsuariosRegistrados";
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridUsuarios;
    }
}