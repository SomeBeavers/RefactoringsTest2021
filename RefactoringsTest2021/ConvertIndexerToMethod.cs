using System;

namespace RefactoringsTest2021
{
    public class ConvertIndexerToMethod
    {
        public class Book
        {
            public string Author { get; set; }
            public string Title { get; set; }
        }

        private Book[] books;

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="index">comment</param>
        /// <param name="name">comment</param>
        /// <returns>comment</returns>
        public Book this[int index, string name]
        {
            get
            {
                if (index >= books.Length)
                    throw new IndexOutOfRangeException();
                return books[index];
            }
            set
            {
                if (index >= books.Length)
                    throw new IndexOutOfRangeException();
                books[index] = value;
            }
        }

        public void TestCopyBook(int copy, int to, string name)
        {
            this[to, name] = this[copy, name];
        }
    }
}