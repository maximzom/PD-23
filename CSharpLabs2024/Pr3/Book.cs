using System;

namespace Classes
{
    public class Book
    {
        private readonly Title titleBook;
        private Author authorBook;
        private Content contentBook;

        public Book(string titleOfBook, string authorOfBook, string contentOfBook)
        {
            titleBook = new Title(titleOfBook);
            authorBook = new Author(authorOfBook);
            contentBook = new Content(contentOfBook);
        }

        public void Show()
        {
            titleBook.Show();
            authorBook.Show();
            contentBook.Show();

            Console.ResetColor();
        }

        public void ShowAuthorOfBook(string authorOfBook)
        {
            authorBook.AuthorOfBook = authorOfBook;
        }

        public void ShowContentOfBook(string contentOfBook)
        {
            contentBook.ContentOfBook = contentOfBook;
        }
    }
}