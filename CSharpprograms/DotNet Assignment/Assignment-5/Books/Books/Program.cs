using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine("Book Name: " + BookName);
            Console.WriteLine("Author Name: " + AuthorName);
        }

    }
    class BookShelf
    {
        private Books[]  b = new Books[5];

        public Books this[int i]
        {
            get { return b[i]; }
            set { b[i] = value; }
        }
    }

    class Driver
    {
        static void Main()
        {
            BookShelf bookshelf = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Book Name {i+1}");
                string BookName = Console.ReadLine();
                Console.WriteLine($"Enter Author Name {i+1}");
                string AuthorName = Console.ReadLine();
                bookshelf[i] = new Books(BookName, AuthorName);
            }
            
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Book {i+1} details");
                bookshelf[i].Display();

            }
            Console.ReadLine();
        }
        
    }
}

