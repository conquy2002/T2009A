using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_040.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImg { get; set; }
    }
    public class BookManager
    {
        public static  List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "a", Author = "b", CoverImg = "Assets/StoreLogo.png" });
            books.Add(new Book { BookId = 2, Title = "a", Author = "b", CoverImg = "Assets/StoreLogo.png" });
            books.Add(new Book { BookId = 3, Title = "a", Author = "b", CoverImg = "Assets/StoreLogo.png" });
            return books;
        }
    }
}
