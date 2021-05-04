using System;

namespace Library
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthorName { get; set; }
        public string BookAuthorSurname { get; set; }
        public DateTime BookDate { get; set; }
        public Book()
        {
            BookId = 0;
            BookName = string.Empty;
            BookAuthorName = string.Empty;
            BookAuthorSurname = string.Empty;
            BookDate = new DateTime();
        }

    }
}