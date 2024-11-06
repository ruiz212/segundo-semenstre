namespace Proyecto_final
{
    public partial class RegistrarUsuario : Form
    {


        Usuario usuario;
        public RegistrarUsuario()
        {
            InitializeComponent();
        }


        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Dinamismo(object sender, EventArgs e)
        {
            //Esta parte del codigo ralisa el dinamismo del codigo
            grpUserEstudiante.Visible = false;
            grpUserMaestro.Visible = false;

            switch (cmbTipoUsuario.SelectedIndex)
            {
                case 0:
                    grpUserEstudiante.Visible = true;
                    break;
                case 1:
                    grpUserMaestro.Visible = true;
                    break;
            }




        }

        private void AgregarUsuario(object sender, EventArgs e)
        {
            //Esta parte del codigo realiza la logica de agregar la informacion a una lista
            if (cmbTipoUsuario.SelectedIndex == 0)
            {
                var usuarioAlumno = new UsuarioAlumno(txtNombre.Text, txtNumeroCarnet.Text, txtCarrera.Text);
                Almasenador.usuarioAlumnos.Add(usuarioAlumno);
                MessageBox.Show($"El usuario agregado es: {usuarioAlumno.NumeroCarnet}", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
