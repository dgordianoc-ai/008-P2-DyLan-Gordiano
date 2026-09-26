

namespace Biblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Libro> libros = new List<Libro>();
            int siguienteId = 1;

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine().Trim();

            Console.Write("Ingrese el autor: ");
            string autor = Console.ReadLine().Trim();

            libros.Add(new Libro
            {
                Id = siguienteId,
                Titulo = titulo,
                Autor = autor
            });

            siguienteId++;

            Console.WriteLine("Libro agregado.");
        }
    }
}