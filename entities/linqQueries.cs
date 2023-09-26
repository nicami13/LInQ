using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace suma.entities
{
    public class LinqQueries
    {
        List<Book> lstBooks = new List<Book>();



public LinqQueries(){

using(StreamReader reader = new StreamReader("books.json")){

string json = reader.ReadToEnd();
this.lstBooks = System.Text.Json.JsonSerializer
.Deserialize<List<Book>>(json,new System.Text.Json.JsonSerializerOptions()
{PropertyNameCaseInsensitive = true}) ?? new List<Book>();

}
}
public IEnumerable<Book> Al1Collection(){

return lstBooks;

}

//1 <summary>
/// Metodo que permite seleccionar libros cuyo año de pub mayor 2000
//1 </sumary>
/// <returns></returns>
public IEnumerable<Book> LibrosDespuesDe2000(){
//Extension method
//return 1stBooks.Where(book => book.PublishedDate.Year > 2000);
return from book in lstBooks
where book.PublishedDate.Year >2000
select book;
    }
public IEnumerable<Book> ObtenerLibrosPublicadosEn2005()
{
    // Usar Any para verificar si existe al menos un libro publicado en 2005.
    bool existeLibroEn2005 = lstBooks.Any(book => book.PublishedDate.Year == 2005);

    if (existeLibroEn2005)
    {
        // Usar Where para obtener todos los libros publicados en 2005.
        var librosEn2005 = lstBooks.Where(book => book.PublishedDate.Year == 2005);
        
        // Devolver la lista de libros en 2005.
        return librosEn2005;
    }
    else
    {
        // Si no existe ningún libro en 2005, devolver una secuencia vacía.
        return Enumerable.Empty<Book>();
    }
}





}
}

