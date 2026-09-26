
namespace Biblioteca
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public string Autor { get; set; } = "";

        public override string ToString()
        {
            return $"{Id,-3} {Titulo,-25} {Autor,-20}";
        }
    }
}