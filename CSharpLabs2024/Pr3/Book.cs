using System;

namespace Pr3
{
    public class Book
    {
        private string titleOfBook;
        private string authorOfBook;
        private string contentOfBook;

        public Book(string titleOfBook, string authorOfBook, string contentOfBook)
        {
            this.titleOfBook = titleOfBook;
            this.authorOfBook = authorOfBook;
            this.contentOfBook = contentOfBook;
        }

        public void ShowTitleOfBook()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ");
            Console.WriteLine("Назва книги: " + titleOfBook + ".");
        }

        public void ShowAuthorOfBook()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Автор: " + authorOfBook + ".");
        }

        public void ShowContentOfBook()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Змiст: " + contentOfBook + ".");
            Console.WriteLine(" ");
        }

        public void Show()
        {
            ShowTitleOfBook();
            ShowAuthorOfBook();
            ShowContentOfBook();
            Console.ResetColor();
        }
    }
}
