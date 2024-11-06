namespace Proyecto_final
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            btnBuscarPorISBN = new Button();
            txtBuscarISBN = new TextBox();
            lblBuscarISBN = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            usuariosRegistradoToolStripMenuItem = new ToolStripMenuItem();
            registrarUsuarioToolStripMenuItem1 = new ToolStripMenuItem();
            usuarioRegistradosToolStripMenuItem = new ToolStripMenuItem();
            prestarLibroToolStripMenuItem = new ToolStripMenuItem();
            prestarLibroToolStripMenuItem1 = new ToolStripMenuItem();
            librosPrestadosToolStripMenuItem = new ToolStripMenuItem();
            librosDisponiblesToolStripMenuItem = new ToolStripMenuItem();
            agregarLibroToolStripMenuItem = new ToolStripMenuItem();
            generarCitaApaToolStripMenuItem = new ToolStripMenuItem();
            toolTipCombinacionesTeclas = new ToolTip(components);
            dataGridView2 = new DataGridView();
            panel5 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            dataGridLibro = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            filtrarPorDisponiblesToolStripMenuItem = new ToolStripMenuItem();
            fitrarPorPrestadosToolStripMenuItem = new ToolStripMenuItem();
            buscarPorISBNToolStripMenuItem = new ToolStripMenuItem();
            mostrarTodosToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 109);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBuscarPorISBN);
            panel2.Controls.Add(txtBuscarISBN);
            panel2.Controls.Add(lblBuscarISBN);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 81);
            panel2.TabIndex = 1;
            // 
            // btnBuscarPorISBN
            // 
            btnBuscarPorISBN.Location = new Point(933, 46);
            btnBuscarPorISBN.Name = "btnBuscarPorISBN";
            btnBuscarPorISBN.Size = new Size(117, 29);
            btnBuscarPorISBN.TabIndex = 3;
            btnBuscarPorISBN.Text = "Buscar";
            btnBuscarPorISBN.UseVisualStyleBackColor = true;
            btnBuscarPorISBN.Visible = false;
            btnBuscarPorISBN.Click += btnBuscarPorISBN_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(685, 48);
            txtBuscarISBN.MaxLength = 6;
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(216, 27);
            txtBuscarISBN.TabIndex = 2;
            toolTipCombinacionesTeclas.SetToolTip(txtBuscarISBN, "Precione ESC para dejar de buscar");
            txtBuscarISBN.Visible = false;
            // 
            // lblBuscarISBN
            // 
            lblBuscarISBN.AutoSize = true;
            lblBuscarISBN.Location = new Point(729, 15);
            lblBuscarISBN.Name = "lblBuscarISBN";
            lblBuscarISBN.Size = new Size(115, 20);
            lblBuscarISBN.TabIndex = 1;
            lblBuscarISBN.Text = "Buscar por ISBN";
            lblBuscarISBN.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, usuariosRegistradoToolStripMenuItem, prestarLibroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1179, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 24);
            toolStripMenuItem1.Text = "Pagina Principal";
            // 
            // usuariosRegistradoToolStripMenuItem
            // 
            usuariosRegistradoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarUsuarioToolStripMenuItem1, usuarioRegistradosToolStripMenuItem });
            usuariosRegistradoToolStripMenuItem.Name = "usuariosRegistradoToolStripMenuItem";
            usuariosRegistradoToolStripMenuItem.Size = new Size(79, 24);
            usuariosRegistradoToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarUsuarioToolStripMenuItem1
            // 
            registrarUsuarioToolStripMenuItem1.Name = "registrarUsuarioToolStripMenuItem1";
            registrarUsuarioToolStripMenuItem1.Size = new Size(220, 26);
            registrarUsuarioToolStripMenuItem1.Text = "Registrar Usuario";
            registrarUsuarioToolStripMenuItem1.Click += RegistraUsuarios;
            // 
            // usuarioRegistradosToolStripMenuItem
            // 
            usuarioRegistradosToolStripMenuItem.Name = "usuarioRegistradosToolStripMenuItem";
            usuarioRegistradosToolStripMenuItem.Size = new Size(220, 26);
            usuarioRegistradosToolStripMenuItem.Text = "Usuario registrados";
            usuarioRegistradosToolStripMenuItem.Click += UsuariosRegistrado;
            // 
            // prestarLibroToolStripMenuItem
            // 
            prestarLibroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prestarLibroToolStripMenuItem1, librosPrestadosToolStripMenuItem, librosDisponiblesToolStripMenuItem, agregarLibroToolStripMenuItem, generarCitaApaToolStripMenuItem });
            prestarLibroToolStripMenuItem.Name = "prestarLibroToolStripMenuItem";
            prestarLibroToolStripMenuItem.Size = new Size(90, 24);
            prestarLibroToolStripMenuItem.Text = "Biblioteca";
            // 
            // prestarLibroToolStripMenuItem1
            // 
            prestarLibroToolStripMenuItem1.Name = "prestarLibroToolStripMenuItem1";
            prestarLibroToolStripMenuItem1.Size = new Size(214, 26);
            prestarLibroToolStripMenuItem1.Text = "Prestar libro";
            // 
            // librosPrestadosToolStripMenuItem
            // 
            librosPrestadosToolStripMenuItem.Name = "librosPrestadosToolStripMenuItem";
            librosPrestadosToolStripMenuItem.Size = new Size(214, 26);
            librosPrestadosToolStripMenuItem.Text = "Libros Prestados";
            // 
            // librosDisponiblesToolStripMenuItem
            // 
            librosDisponiblesToolStripMenuItem.Name = "librosDisponiblesToolStripMenuItem";
            librosDisponiblesToolStripMenuItem.Size = new Size(214, 26);
            librosDisponiblesToolStripMenuItem.Text = "Libros Disponibles";
            // 
            // agregarLibroToolStripMenuItem
            // 
            agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            agregarLibroToolStripMenuItem.Size = new Size(214, 26);
            agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            agregarLibroToolStripMenuItem.Click += agregarLibroToolStripMenuItem_Click;
            // 
            // generarCitaApaToolStripMenuItem
            // 
            generarCitaApaToolStripMenuItem.Name = "generarCitaApaToolStripMenuItem";
            generarCitaApaToolStripMenuItem.Size = new Size(214, 26);
            generarCitaApaToolStripMenuItem.Text = "Generar cita Apa";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(661, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(518, 643);
            dataGridView2.TabIndex = 1;
            toolTipCombinacionesTeclas.SetToolTip(dataGridView2, "Precione enter para buscr");
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(1179, 643);
            panel5.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1179, 643);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1179, 643);
            panel8.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(dataGridView2);
            panel9.Controls.Add(dataGridLibro);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1179, 643);
            panel9.TabIndex = 2;
            // 
            // dataGridLibro
            // 
            dataGridLibro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLibro.ContextMenuStrip = contextMenuStrip1;
            dataGridLibro.Location = new Point(0, 0);
            dataGridLibro.Name = "dataGridLibro";
            dataGridLibro.RowHeadersWidth = 51;
            dataGridLibro.Size = new Size(662, 643);
            dataGridLibro.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { filtrarPorDisponiblesToolStripMenuItem, fitrarPorPrestadosToolStripMenuItem, buscarPorISBNToolStripMenuItem, mostrarTodosToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(224, 100);
            // 
            // filtrarPorDisponiblesToolStripMenuItem
            // 
            filtrarPorDisponiblesToolStripMenuItem.Name = "filtrarPorDisponiblesToolStripMenuItem";
            filtrarPorDisponiblesToolStripMenuItem.Size = new Size(223, 24);
            filtrarPorDisponiblesToolStripMenuItem.Text = "Filtrar por disponibles";
            filtrarPorDisponiblesToolStripMenuItem.Click += filtrarPorDisponiblesToolStripMenuItem_Click;
            // 
            // fitrarPorPrestadosToolStripMenuItem
            // 
            fitrarPorPrestadosToolStripMenuItem.Name = "fitrarPorPrestadosToolStripMenuItem";
            fitrarPorPrestadosToolStripMenuItem.Size = new Size(223, 24);
            fitrarPorPrestadosToolStripMenuItem.Text = "Fitrar por prestados";
            fitrarPorPrestadosToolStripMenuItem.Click += fitrarPorPrestadosToolStripMenuItem_Click;
            // 
            // buscarPorISBNToolStripMenuItem
            // 
            buscarPorISBNToolStripMenuItem.Name = "buscarPorISBNToolStripMenuItem";
            buscarPorISBNToolStripMenuItem.Size = new Size(223, 24);
            buscarPorISBNToolStripMenuItem.Text = "Buscar por ISBN";
            buscarPorISBNToolStripMenuItem.Click += BuscarPorISBN;
            // 
            // mostrarTodosToolStripMenuItem
            // 
            mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            mostrarTodosToolStripMenuItem.Size = new Size(223, 24);
            mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            mostrarTodosToolStripMenuItem.Click += mostrarTodosToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 752);
            Controls.Add(panel5);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            KeyDown += DesapareserComponete;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridLibro).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem usuariosRegistradoToolStripMenuItem;
        private ToolStripMenuItem prestarLibroToolStripMenuItem;
        private ToolStripMenuItem registrarUsuarioToolStripMenuItem1;
        private ToolStripMenuItem usuarioRegistradosToolStripMenuItem;
        private ToolStripMenuItem prestarLibroToolStripMenuItem1;
        private ToolStripMenuItem librosPrestadosToolStripMenuItem;
        private ToolStripMenuItem librosDisponiblesToolStripMenuItem;
        private ToolTip toolTipCombinacionesTeclas;
        private ToolStripMenuItem agregarLibroToolStripMenuItem;
        private ToolStripMenuItem generarCitaApaToolStripMenuItem;
        private Panel panel5;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private DataGridView dataGridLibro;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Label lblBuscarISBN;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem filtrarPorDisponiblesToolStripMenuItem;
        private ToolStripMenuItem fitrarPorPrestadosToolStripMenuItem;
        private ToolStripMenuItem buscarPorISBNToolStripMenuItem;
        private ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private TextBox txtBuscarISBN;
        private Button btnBuscarPorISBN;
    }
}
