namespace Proyecto_final
{
    public class Libro                      
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AñoPublicacion { get; set; }
        public bool Disponibilidad { get; set; }
       
        public Libro(string isbn, string titulo, string autor, string editorial, int añoPublicacion, bool disponibilidad)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AñoPublicacion = añoPublicacion;
            Disponibilidad = disponibilidad;
        }
        public override string ToString()
        {
            return $"{ISBN}|{Titulo}|{Autor},{AñoPublicacion}"; 
        }
    }
}
