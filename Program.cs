using Newtonsoft;
using System.Linq;
using suma.entities;
internal class Program
{
    private static void ImprimirValores(IEnumerable<Book> books)
{

int registros = 0;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Magenta;

Console.WriteLine("{0,-70} {1,7} {2,20}", "Titulo", "N. Paginas", "Fecha publicacion");

foreach (Book book in books)


{

Console.ForegroundColor = ConsoleColor.Yellow;

registros += 1;

Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
}
}
    private static void Main(string[] args)
    {
        int?[] args2= new int?[5];
//int »j

Console.WriteLine(args2[0]);

LinqQueries queries = new LinqQueries();

ImprimirValores(queries.ObtenerLibrosPublicadosEn2005());

}
}