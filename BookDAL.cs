using System;
using System.Collections.Generic;
using Library;

namespace LibraryDAL
{
    public class BookDAL
    {
        public static List<Book> books = new List<Book>();
        public List<Book> GetAllBooksDAL()
        {
            return books;
        }
        public bool AddBooksDAL(int bookId, string bookName, string bookAuthorName, string bookAuthorSurname, DateTime bookDate)
        {
            bool isDone = false;
            try
            {
                Book addBook = new Book() { BookId = bookId, BookName = bookName, BookAuthorName = bookAuthorName, BookAuthorSurname = bookAuthorSurname, BookDate = bookDate };
                books.Add(addBook);
                isDone = true;

            }
            catch (ApplicationException)
            {
                isDone = false;
            }
            return isDone;
        }
        public bool FindBooksNameDAL(int bookId, string bookName, string bookAuthorName, string bookAuthorSurname, DateTime bookDate)
        {
            bool isDone = false;
            try
            {
                Book findBook = books.Find(s => s.BookName == bookName);
                Console.WriteLine("--------------------Lista-Książek------------------------");
                Console.WriteLine("--Id-----Tytuł-----Imię-i-Nazwisko-Autora---------Data-----");
                //foreach (Book book in books)
                //{
                    Console.WriteLine("  " + findBook.BookId + "\t" + findBook.BookName + "\t  " + findBook.BookAuthorName + "\t" + findBook.BookAuthorSurname + "\t" + findBook.BookDate);
                //}
                isDone = true;
            }
            catch(ApplicationException)
            {
                isDone = false;
            }
            return isDone;
        }
        public bool FindBooksAuthorDAL(int bookId, string bookName, string bookAuthorName, string bookAuthorSurname, DateTime bookDate)
        {
            bool isDone = false;
            try
            {
                Book findBook = books.Find(s => s.BookAuthorName == bookAuthorName && s.BookAuthorSurname == bookAuthorSurname);
                Console.WriteLine("--------------------Lista-Książek------------------------");
                Console.WriteLine("--Id-----Tytuł-----Imię-i-Nazwisko-Autora---------Data-----");
                //foreach (Book book in books)
                //{
                    Console.WriteLine("  " + findBook.BookId + "\t" + findBook.BookName + "\t  " + findBook.BookAuthorName + "\t" + findBook.BookAuthorSurname + "\t" + findBook.BookDate);
                //}
                isDone = true;
            }
            catch(ApplicationException)
            {
                isDone = false;
            }
            return isDone;
        }
    }
}