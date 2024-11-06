namespace Proyecto_final
{
    public class UsuarioMaestro : Usuario
    {
        public string NumeroTrabajador { get; set; }
        public string AreaConosimiento { get; set; }

        public UsuarioMaestro(string nombre, string numeroTrabajador, string areaConosimiento) : base(nombre)
        {
            NumeroTrabajador = numeroTrabajador;

            AreaConosimiento = areaConosimiento;
        }
    }
}
