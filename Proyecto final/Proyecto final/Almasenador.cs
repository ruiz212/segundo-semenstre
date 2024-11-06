namespace Proyecto_final
{
    public static class Almasenador
    {
        public static List<UsuarioAlumno> usuarioAlumnos = new List<UsuarioAlumno>();
        public static List<UsuarioMaestro> usuarioMaestros = new List<UsuarioMaestro>();
        //El sitema inicializa unos libros para que siempre tenga libros en la biblioteca ya que el sistema no implementa bases de datos para guarda libros permanenete mente
        public static List<Libro> libros = new List<Libro>
        {
   new Libro("1234PR", "JavaScript: The Good Parts", "Douglas Crockford", "O'Reilly Media", 2010,false),
    new Libro("5678CD", "The Clean Coder", "Robert C. Martin", "Prentice Hall", 2011,false),
    new Libro("9101EF", "Pro Git", "Scott Chacon", "Apress", 2014, false),
    new Libro("1122GH", "Python Crash Course", "Eric Matthes", "No Starch Press", 2015, true),
    new Libro("3344IJ", "Learning React", "Alex Banks", "O'Reilly Media", 2017, true),
    new Libro("5566KL", "Effective Modern C++", "Scott Meyers", "O'Reilly Media", 2014,true),
    new Libro("7788MN", "You Don’t Know JS", "Kyle Simpson", "O'Reilly Media", 2015, true),
    new Libro("9900OP", "Fluent Python", "Luciano Ramalho", "O'Reilly Media", 2015,true),
    new Libro("2233QR", "Introduction to Algorithms", "Thomas H. Cormen", "MIT Press", 2011, true),
    new Libro("4455ST", "JavaScript and JQuery", "Jon Duckett", "Wiley", 2014,true),
    new Libro("6677UV", "C# in Depth", "Jon Skeet", "Manning Publications", 2019, true),
    new Libro("8899WX", "Head First Python", "Paul Barry", "O'Reilly Media", 2016,true),
    new Libro("1023YZ", "Designing Data-Intensive Applications", "Martin Kleppmann", "O'Reilly Media", 2017, true),
    new Libro("3045AB", "Deep Learning", "Ian Goodfellow", "MIT Press", 2016,true),
    new Libro("5067CD", "Kubernetes Up & Running", "Kelsey Hightower", "O'Reilly Media", 2017, true),
    new Libro("7089EF", "Hands-On Machine Learning with Scikit-Learn, Keras, and TensorFlow", "Aurélien Géron", "O'Reilly Media", 2019, true),
    new Libro("9012GH", "Grokking Algorithms", "Aditya Bhargava", "Manning Publications", 2016, true),
    new Libro("2345IJ", "Programming Rust", "Jim Blandy", "O'Reilly Media", 2018,true),
    new Libro("4567KL", "Introduction to Machine Learning with Python", "Andreas C. Müller", "O'Reilly Media", 2016, true),
    new Libro("6789MN", "Python for Data Analysis", "Wes McKinney", "O'Reilly Media", 2017,true)
        };
        public static event Action LibrosActualizados;


    }
}
