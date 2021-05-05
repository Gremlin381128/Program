using System;
using System.Collections.Generic;
using System.Linq;

using Library;
using LibraryDAL;

namespace LibraryBLL
{
    public class BookBLL
    {
        private bool BookValidation(int bookId, string bookName, string bookAuthorName,string BookAuthorSurname, DateTime BookDate)
        {
            bool bookValid;

            if (bookId==0 || bookId>=100000)
            {
                Console.WriteLine("Niepoprawne id książki!!! Proszę podać z przedziału od 1 do 100000");
                bookValid = false;
            }
            else if(bookName.Length <= 2 || bookName.Length>30)
            {
                Console.WriteLine("Niepoprawny tytuł książki!!! Tytuł musi mieć od 3 do 30 znaków");
                bookValid = false;
            }
            else if (bookName.Any(char.IsDigit))
            {
                Console.WriteLine("Niepoprawny tytuł książki!!! Tytuł niepowinien zawierać liczb");
                bookValid = false;
            }

            else if (bookAuthorName.Length <= 2 || bookAuthorName.Length > 30)
            {
                Console.WriteLine("Niepoprawne imię autora!!! Imię musi mieć od 3 do 30 znaków");
                bookValid = false;
            }
            else if (bookAuthorName.Any(char.IsDigit))
            {
                Console.WriteLine("Niepoprawne imię autora!!! Imię niepowinno zawierać liczb");
                bookValid = false;
            }
            else if (BookAuthorSurname.Length <= 2 || BookAuthorSurname.Length > 30)
            {
                Console.WriteLine("Niepoprawne nazwisko autora!!! Nazwisko musi mieć od 3 do 30 znaków");
                bookValid = false;
            }
            else if (BookAuthorSurname.Any(char.IsDigit))
            {
                Console.WriteLine("Niepoprawne nazwisko autora!!! Nazwisko niepowinno zawierać liczb");
                bookValid = false;
            }
            else
            {
                bookValid=true;
            }
            return bookValid;
        }
        BookDAL dalBook = new BookDAL();
        public void AddBookBLL(int bookId, string bookName, string BookAuthorName, string BookAuthorSurname, DateTime BookDate)
        {
            bool isValidated = BookValidation(bookId, bookName, BookAuthorName, BookAuthorSurname, BookDate);
            if (isValidated)
            {
                /*BookDAL dalBook = new BookDAL();*/
                bool isDone = dalBook.AddBooksDAL(bookId, bookName, BookAuthorName, BookAuthorSurname, BookDate);
                if (isDone == true)
                {
                    Console.WriteLine("Książka została dodana");
                }
                else
                {
                    Console.WriteLine("Spróbuj ponownie");
                }
            }
            else
            {
                Console.WriteLine("Spróbuj ponownie");
            }
        }
        public void FindBookNameBLL(int bookId, string bookName, string BookAuthorName, string BookAuthorSurname, DateTime BookDate)
        {
                bool isDone = dalBook.FindBooksNameDAL(bookId, bookName, BookAuthorName, BookAuthorSurname, BookDate);
                if (isDone==true)
                {
                    Console.WriteLine("Książka znaleziona");
                }
                else
                {
                    Console.WriteLine("Spróbuj ponownie");
                }
        }
        public List<Book> GetAllBookBLL()
        {
            List<Book> books = dalBook.GetAllBooksDAL();
            return books;
        }
    }
}