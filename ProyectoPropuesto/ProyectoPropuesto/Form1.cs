using Microsoft.Win32.SafeHandles;


namespace ProyectoPropuesto
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            grpElectric.Visible = false;
            lblCapasidad.Text = "Capadidad de la bateria";


        }

        private void combVehiculoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (combVehiculoTipo.SelectedItem.ToString())
            {
                case "Electrico":
                    lblCapasidad.Text = "Capasidad de la bateria";
                    grpElectric.Visible = true;
                    grpHibridoComponete.Visible = false;
                    break;
                case "Gasolina":
                    lblCapasidad.Text = "Cilindrada";
                    grpElectric.Visible = true;
                    grpHibridoComponete.Visible = false;

                    break;
                case "Hibrido":
                    grpHibridoComponete.Visible = true;
                    grpElectric.Visible = false;
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = null;

            if(combVehiculoTipo.SelectedItem.ToString() == "Electrico")
            {
                vehiculo = new VehiculoElectrico(txtModelo.Text, dtAño.Value, Convert.ToDouble(txtCapasidad.Text));
                
                   
               
            }else if(combVehiculoTipo.SelectedItem.ToString() == "Gasolina")
            {
                vehiculo = new VehiculoGasolina(txtModelo.Text, dtAño.Value, Convert.ToDouble(txtCapasidad.Text));
                
            }else if(combVehiculoTipo.SelectedItem.ToString() == "Hibrido")
            {
                vehiculo = new VehiculoHibrido(txtModelo.Text, dtAño.Value, Convert.ToDouble(txtBateriaCapasidad.Text), Convert.ToDouble(txtCilindrada.Text));
               
            }

            if(vehiculo != null)
            {
                double velocidadMaxima = vehiculo.CalcularVelosidadMaxima();
                string TipoCombustible = vehiculo.TipoCombustible();

                txtVelocidadMaxima.Text = $"{velocidadMaxima} km/h";
                lblTipoCombustible.Text = TipoCombustible;
            }



        }
    }
}
