using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0120
{
    internal class BookRepository
    {
        public List<Books> books;

        public BookRepository()
        {
            books = new List<Books>();
            
        }
   
        public void AddBookToList()
        {
            
            int howMany;
            string newTitle;
            string newAuthor;
            Console.WriteLine("How many books to add :");
            howMany = int.Parse(Console.ReadLine());

            for (int i = 0; i < howMany; i++)
            {
                Console.WriteLine("Name of book :");
                newTitle = Console.ReadLine();

                Console.WriteLine("Author of book:");
                newAuthor = Console.ReadLine();

                books.Add(new Books(){ Title = newTitle, Author = newAuthor });
            }
        }
        public void SaveBookToFile(Books book )
        {
            WriterService writerService = new WriterService();
            writerService.Write(book.Title,book.Author);

        }


    }
}
