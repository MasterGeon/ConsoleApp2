using ConsoleApp2;

Book phyBook = new Book("The Witcher", "AL");
EBook digiBook = new EBook("Lord of the rings", "jRR Tolken");

Console.WriteLine("Borrowing Physical book: ");
phyBook.Borrow("Henri");

phyBook.Borrow("Erik");

phyBook.Return();

phyBook.Borrow("Erik");

digiBook.Borrow("Erik");

digiBook.Borrow("Henri");

digiBook.Return();