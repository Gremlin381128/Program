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