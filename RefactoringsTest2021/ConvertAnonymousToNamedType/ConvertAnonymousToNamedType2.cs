using System.Collections.Generic;
using System.Linq;

namespace RefactoringsTest2021.ConvertAnonymousToNamedType
{
    public partial class ConvertAnonymousToNamedType
    {
        public string Test(List<Book> books)
        {
            var anno = "Test".Select(Author => new { Author, X = 2 });

            var bookList = from book in books
                select new { Author = book.Author, title12112 = book.Title };

            var bookListNotApplied = from book in books
                select new { Author = book.Author, title = new { book.Title } };

            var bookNew = bookList.ToList().FirstOrDefault(book => book.Author == "King");

            return bookNew?.Author;
        }
    }
}