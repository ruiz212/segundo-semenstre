namespace Proyecto_final
{
    public class IsbnGenereitor
    {
        private static Random random = new Random();

        public static string GenerarISBN()
        {
            // Generar 4 dígitos aleatorios
            string digitos = random.Next(1000, 9999).ToString();

            // Generar 2 letras aleatorias
            char letra1 = (char)random.Next('A', 'Z' + 1);
            char letra2 = (char)random.Next('A', 'Z' + 1);
            string letras = $"{letra1}{letra2}";

            return $"{digitos}{letras}";
        }
    }
}
