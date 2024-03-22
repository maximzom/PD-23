using System;

namespace Classes
{
    public class Content
    {
        private string contentOfBook;

        public string ContentOfBook
        {
            get { return contentOfBook; }
            set { contentOfBook = value; }
        }

        public Content(string content)
        {
            contentOfBook = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Змiст: {contentOfBook}");
            Console.ResetColor();
        }
    }
}