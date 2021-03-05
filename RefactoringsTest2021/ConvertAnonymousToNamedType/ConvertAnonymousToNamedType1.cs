using System.Collections.Generic;
using System.Linq;

namespace RefactoringsTest2021.ConvertAnonymousToNamedType
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }

    public partial class ConvertAnonymousToNamedType
    {

        private void Test1(List<Book> library)
        {
            var bookCatalog = from item in library
                //title111
                select new SomeClassRenamed { Author = item.Author, title111 = item.Title };
        }
    }

    public class SomeClassRenamed
    {
        public string Author { get; set; }
        public string title111 { get; set; }
    }

    class MyNewTest
    {
        private void Foo(List<Book> library, bool confirmed)
        {
            var data = confirmed
                ? new { confirmed }
                : new
                {
                    confirmed = false
                };

            var bookCatalog = from item in library
                select new SomeClassRenamed { Author = item.Author, title111 = item.Title };
        }

        private void Foo2(List<Book> library)
        {
            var bookCatalog1 = from item in library
                select new { Author = item.Author, title111 = item.Title };
            var bookCatalog = from item in library
                select new { Author = item.Author, title111 = item.Title };

        }
    }
}