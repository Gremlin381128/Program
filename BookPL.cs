using System;
using System.Collections.Generic;
using System.Linq;

using Library;
using LibraryBLL;

namespace Yes
{
    class BookPL
    {
        private Book book = new Book();
        public void AddBook()
        {
            try{
                Console.WriteLine("Wprowadź dane książki...");
                Console.Write("Numer Id: ");
                book.BookId = int.Parse(Console.ReadLine());
                Console.Write("Tytuł: ");
                book.BookName = Console.ReadLine();
                Console.Write("Imię autora: ");
                book.BookAuthorName = Console.ReadLine();
                Console.Write("Nazwisko autora: ");
                book.BookAuthorSurname = Console.ReadLine();
                Console.Write("Data wydania książki: ");
                book.BookDate = DateTime.Parse(Console.ReadLine());
                BookBLL addBook = new BookBLL();
                addBook.AddBookBLL(book.BookId, book.BookName, book.BookAuthorName, book.BookAuthorSurname, book.BookDate);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadź poprawne dane");
            }
        }
        public void FindBookName()
        {
            try
            {
                Console.WriteLine("Wprowadź dane szukanej książki");
                Console.Write("Tytuł książki: ");
                book.BookName = Console.ReadLine();
                BookBLL findBook = new BookBLL();
                findBook.FindBookNameBLL(book.BookId, book.BookName, book.BookAuthorName, book.BookAuthorSurname, book.BookDate);
            }
            catch
            {
                Console.WriteLine("Wprowadzono niepoprawną wartość");
            }
        }
        public void FindBookAuthor()
        {
            try
            {
                Console.WriteLine("Wprowadź dane szukanej książki");
                Console.Write("Imię autora książki: ");
                book.BookAuthorName = Console.ReadLine();
                Console.Write("Nazwisko autora książki: ");
                book.BookAuthorSurname = Console.ReadLine();
                BookBLL findBook = new BookBLL();
                findBook.FindBookAuthorBLL(book.BookId, book.BookName, book.BookAuthorName, book.BookAuthorSurname, book.BookDate);
            }
            catch
            {
                Console.WriteLine("Wprowadzono niepoprawną wartość");
            }
        }
        public void GetAllBook()
        {
            List<Book> books = new List<Book>();
            BookBLL bookTemp = new BookBLL();
            books = bookTemp.GetAllBookBLL();
            Console.WriteLine("---------------------------Lista-Książek---------------------------");
            Console.WriteLine("--Id-----Tytuł---------------Imię-i-Nazwisko-Autora-------------------Data-----");
            foreach (Book book in books)
            {
                Console.WriteLine("  " + book.BookId + "\t" + book.BookName + "\t  " + book.BookAuthorName + "\t" + book.BookAuthorSurname + "\t" + book.BookDate);
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}