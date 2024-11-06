namespace Proyecto_final
{
    public class UsuarioAlumno : Usuario
    {
        public string NumeroCarnet { get; set; }
        public string NombreCarrera { get; set; }
        public UsuarioAlumno(string nombre, string numeroCarnet, string nombreCarrera) : base(nombre)
        {
            NumeroCarnet = numeroCarnet;
            NombreCarrera = nombreCarrera;
        }
    }
}
