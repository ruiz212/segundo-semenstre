namespace Trabajo3Uni
{
    public partial class Form1 : Form
    {
        private List<ProduccionSA> trabajadores = new List<ProduccionSA>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (trabajadores.Count > 5)
            {
                MessageBox.Show("Has supearo el limite de trabajadores permitidos", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombre = Name.Text;
            string puesto = TxtPuesto.Text;
            string departamento = TxtDepartamento.Text;
            if (departamento.ToLower() == "ventas" || departamento.ToLower() == "produccion")
            {
                MessageBox.Show($"Departamento aprobado{departamento}");
            }
            else
            {
                MessageBox.Show($"Este departamento NO esta aprobado");
                return;
            }

            decimal _Salario;
            if (decimal.TryParse(TxtSalario.Text, out _Salario))
            {
                // Si la conversión fue exitosa, ejecuta este código
                MessageBox.Show($"El salario ingresado es válido: {_Salario}");

                ProduccionSA nuevoTrabajador = new ProduccionSA(nombre, puesto, departamento, _Salario);
                trabajadores.Add(nuevoTrabajador);
                MessageBox.Show($"Trabajador agregado: {nombre}, Puesto: {puesto}, Departamento: {departamento}, Salario: {_Salario:C}");
            }
            else
            {
                // Si la conversión falló, muestra un mensaje de error
                MessageBox.Show("Por favor, ingrese un salario válido.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (trabajadores.Count == 0)
            {
                MessageBox.Show("No hay trabajadores registrado");
                return;
            }
            string mensaje = "Trabajadores del departamento de ventas \n";
            bool haytrabajoderesVenta = false;

            foreach (var trabajador in trabajadores)
            {
                if (trabajador.Departamento.ToLower() == "ventas")
                {
                    haytrabajoderesVenta = true;
                    Ventas.Items.Clear();
                    Ventas.Items.Add($"{mensaje}");
                    Ventas.Items.Add($"Nombre: {trabajador.Nombre}");
                    Ventas.Items.Add($"Puesto: {trabajador.Puesto}");
                    Ventas.Items.Add($" Salario: {trabajador.Salario:C}");
                }else if(trabajador.Departamento.ToLower() == "produccion")
                {
                    Produccion.Items.Clear();
                    Produccion.Items.Add($"{mensaje}");
                    Produccion.Items.Add($"Nombre: {trabajador.Nombre}");
                    Produccion.Items.Add($"Puesto: {trabajador.Puesto}");
                    Produccion.Items.Add($" Salario: {trabajador.Salario:C}");
                }
            }



        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Name.Clear();
            TxtPuesto.Clear();
            TxtSalario.Clear();

        }


    }
}



