using System.ComponentModel;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarDataGridView();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(DesapareserComponete);
        }

        private void RegistraUsuarios(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
        }

        private void UsuariosRegistrado(object sender, EventArgs e)
        {
            UsuariosRegistrados usuariosRegistrados = new UsuariosRegistrados();
            usuariosRegistrados.Show();

        }


        private void OnLibroAgregado(Libro nuevoLibro)
        {


            // Actualizar el DataGridView para mostrar el nuevo libro
            ActualizarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            dataGridLibro.DataSource = null;
            dataGridLibro.DataSource = new BindingList<Libro>(Almasenador.libros);
            dataGridLibro.Refresh();
        }

        private void agregarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarLibro agregarLibroForm = new AgregarLibro();

            // Suscribirse al evento LibroAgregado
            agregarLibroForm.LibroAgregado += OnLibroAgregado;

            // Mostrar el formulario para agregar un libro
            agregarLibroForm.ShowDialog();

            // Desuscribirse del evento después de cerrar el formulario
            agregarLibroForm.LibroAgregado -= OnLibroAgregado;
        }

        private void filtrarPorDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var librosDisponibles = Almasenador.libros.Where(l => l.Disponibilidad == true).ToList();
            dataGridLibro.DataSource = librosDisponibles;
        }

        private void fitrarPorPrestadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var librosNoDisponible = Almasenador.libros.Where(l => l.Disponibilidad == false).ToList();
            dataGridLibro.DataSource = librosNoDisponible;
        }

        private void BuscarPorISBN(object sender, EventArgs e)
        {
            lblBuscarISBN.Visible = true;
            btnBuscarPorISBN.Visible = true;
            txtBuscarISBN.Visible = true;

        }



        private void BuscarLibroPorISBN(string isbn)
        {
            var libro = Almasenador.libros
                         .FirstOrDefault(l => l.ISBN.ToLower() == isbn.ToLower());

            if (libro != null)
            {
                // Si se encuentra el libro, muestra solo ese en el DataGridView
                dataGridLibro.DataSource = new List<Libro> { libro };
            }
            else
            {
                MessageBox.Show("No se encontró ningún libro con el ISBN proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarPorISBN_Click(object sender, EventArgs e)
        {
            string isbn = txtBuscarISBN.Text.Trim();

            if (!string.IsNullOrEmpty(isbn))
            {
                BuscarLibroPorISBN(isbn);
            }
            else
            {
                txtBuscarISBN.Clear();
                MessageBox.Show("Por favor, ingrese un ISBN válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DesapareserComponete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                lblBuscarISBN.Visible = false;
                txtBuscarISBN.Visible = false;
                txtBuscarISBN.Clear();
                btnBuscarPorISBN.Visible = false;

            }
        }

        

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridLibro.DataSource = Almasenador.libros;
        }
    }


}
