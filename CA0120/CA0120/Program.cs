using System;
using System.IO;

namespace CA0120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Books("senis","jura");
            var bookrepository = new BookRepository();
            bookrepository.AddBookToList();
            bookrepository.SaveBookToFile(book);
        }
 
    }
}
