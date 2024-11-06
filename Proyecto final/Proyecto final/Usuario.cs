namespace Proyecto_final
{
    public abstract class Usuario
    {
        public string Nombre { get; set; }
        protected Usuario(string nombre)
        {
            Nombre = nombre;
        }
    }
}
