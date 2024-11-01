using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IBorrowable
    {
        void Borrow(string borrower);
        void Return();
        bool IsBorrowed { get; }
    }
    public class Book : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; }
        public string Borrower { get; private set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsBorrowed = false;
        }
        public void Borrow(string borrower)
        {
            if (!IsBorrowed)
            {
                Borrower = borrower;
                IsBorrowed = true;
                Console.WriteLine($"{Title} has been borrowed by {Borrower}.");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed by {Borrower}.");
            }
        }
        public void Return()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{Title} has been returned by {Borrower}.");
                Borrower = null;
                IsBorrowed = false;
            }
            else
            {
                Console.WriteLine($"{Title} is not currently borrowed.");
            }
        }
    }

}
