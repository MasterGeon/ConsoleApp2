using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EBook : IBorrowable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; private set; }
        public string Borrower { get; private set; }

        public EBook(string title, string author)
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
                Console.WriteLine($"{Title} (E-Book) has been borrowed by {Borrower}.");
            }
            else
            {
                Console.WriteLine($"{Title} (E-Book) is already borrowed by {Borrower}.");
            }
        }
        public void Return()
        {
            if (IsBorrowed)
            {
                Console.WriteLine($"{Title} (E-Book) has been returned by {Borrower}.");
                Borrower = null;
                IsBorrowed = false;
            }
            else
            {
                Console.WriteLine($"{Title} (E-Book) is not currently borrowed.");
            }
        }
    }
}
