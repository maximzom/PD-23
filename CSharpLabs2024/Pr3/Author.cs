using System;

namespace Classes
{
    public class Author
    {
        private string authorOfBook;

        public string AuthorOfBook
        {
            get { return authorOfBook; }
            set { authorOfBook = value; }
        }

        public Author(string name)
        {
            authorOfBook = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Автор: {authorOfBook}.");
            Console.ResetColor();
        }
    }
}