

    public abstract class Vehiculo
    {
        public string Modelo { get; set; }
        public DateTime AñoLansamiento { get; set; }
        public abstract double CalcularVelosidadMaxima();
        public abstract string TipoCombustible();
        protected Vehiculo(string modelo, DateTime añoLansamiento)
        {
            Modelo = modelo;
            AñoLansamiento = añoLansamiento;
        }
    }

    public class VehiculoElectrico : Vehiculo
    {
        public double CapaSidadBateria { get; set; }
        public VehiculoElectrico(string modelo, DateTime añoLansamiento, double capaSidadBateria) : base(modelo, añoLansamiento)
        {
            CapaSidadBateria = capaSidadBateria;
        }

        public override double CalcularVelosidadMaxima()
        {
            return CapaSidadBateria * 3;
        }

        public override string TipoCombustible()
        {
            return "Elctrisidad";
        }
    }
    public class VehiculoGasolina : Vehiculo
    {
        public double Cilindrada { get; set; }
        public VehiculoGasolina(string modelo, DateTime añoLansamiento, double cilindrada) : base(modelo, añoLansamiento)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularVelosidadMaxima()
        {
            return Cilindrada / 10;
        }

        public override string TipoCombustible()
        {
            return "Gasolina";
        }
    }
    public sealed class VehiculoHibrido : Vehiculo
    {
        public double CapasidadBateria { get; set; }
        public double Cilindrada { get; set; }
        public VehiculoHibrido(string modelo, DateTime añoLansamiento, double capasidadBateria, double cilindrada) : base(modelo, añoLansamiento)
        {
            CapasidadBateria = capasidadBateria;
            Cilindrada = cilindrada;
        }

        public override double CalcularVelosidadMaxima()
        {
            return (CapasidadBateria * 2) + (Cilindrada / 15);
        }

        public override string TipoCombustible()
        {
            return "Hibrido(gasolina y elentrisidad)";
        }
    }




