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
    }
}