using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class AgregarLibro : Form
    {
        public delegate void LibroAgregadoEventHandler(Libro nuevoLibro);
        public event LibroAgregadoEventHandler LibroAgregado;
        public AgregarLibro()
        {
            InitializeComponent();
        }
        int añoPublicacion;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntAgregarLibro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAñoPublicacion.Text, out añoPublicacion))
            {

            var nuenvoLibro = new Libro(IsbnGenereitor.GenerarISBN(), txtTitulo.Text,txtAutor.Text,txtEditorial.Text,añoPublicacion,true);
            Almasenador.libros.Add(nuenvoLibro);
                LibroAgregado?.Invoke(nuenvoLibro);
                //Cierra el formulario
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No andes ingredando letras o simbolos raros en lugares que dise año que no sabes sosbruto o que","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           

        }
    }
}
