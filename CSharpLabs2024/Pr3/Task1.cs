using System;

namespace Pr3
{
    public static class Task1
    {
        public static void Run()
        {
            Console.WriteLine("\nЗавдання №1.");
            Console.WriteLine("Створити клас Book. Створити класи Title, Author i Content, кожен з яких має мiстити");
            Console.WriteLine("одне строкове поле i метод void Show().");
            Console.WriteLine("Реалiзуйте можливiсть додавання в книгу назви книги, iменi автора та змiсту.");
            Console.WriteLine("Виведiть на екран рiзними кольорами за допомогою методу Show() назву книги, iм'я автора та змiст.\n");

            Console.Write("Введiть, будь ласка, назву книги: ");
            string titleOfBook = Console.ReadLine();

            Console.Write("Введiть, будь ласка, iм'я автора: ");
            string authorOfBook = Console.ReadLine();

            Console.Write("Введiть, будь ласка, змiст книги: ");
            string contentOfBook = Console.ReadLine();

            Console.Write("\nПiдсумковий результат введеної книги: ");

            Book book = new Book(titleOfBook, authorOfBook, contentOfBook);
            book.Show();
        }
    }
}
