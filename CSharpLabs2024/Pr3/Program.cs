using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практична робота №3.");
            Console.WriteLine("Група - ПД-23.");
            Console.WriteLine("Виконав - Зелiнський Максим.\n");

            Console.WriteLine("Введiть, будь ласка, номер завдання (Вiд 1 до 2):");
            string taskNumber = Console.ReadLine();

            switch (taskNumber)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                default:
                    Console.WriteLine("Данного завдання не має у даннiй роботi.");
                    break;
            }
        }

        class Book
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


        static void Task1()
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

        class Point
        {
            public int X { get; }
            public int Y { get; }
            public string Name { get; }

            public Point(int x, int y, string name)
            {
                X = x;
                Y = y;
                Name = name;
            }
        }

        class Figure
        {
            private Point[] points;
            public string Name { get; }

            public Figure(string name, params Point[] points)
            {
                if (points.Length < 3 || points.Length > 5)
                {
                    throw new ArgumentException("Кількість точок має бути від 3 до 5.");
                }

                this.points = points;
                this.Name = name;
            }

            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }

            public void PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    if (i + 1 < points.Length)
                    {
                        perimeter += LengthSide(points[i], points[i + 1]);
                    }
                    else
                    {
                        perimeter += LengthSide(points[i], points[0]);
                    }
                }

                Console.WriteLine($"Периметр {Name} це {perimeter}.");
            }
        }

        static void Task2()
        {
            Console.WriteLine("\nЗавдання №2.");
            Console.WriteLine("---");

            Console.WriteLine("Введiть, будь ласка, назву фiгури:");
            string figureName = Console.ReadLine();

            Console.WriteLine("Введiть, будь ласка, кiлькiсть точок:");
            int pointCount = int.Parse(Console.ReadLine());

            Point[] points = new Point[pointCount];
            for (int i = 0; i < pointCount; i++)
            {
                Console.WriteLine($"Введiть, будь ласка, назву точки {i + 1}:");
                string pointName = Console.ReadLine();

                Console.WriteLine($"Введiть, будь ласка, координату точки-x {i + 1}:");
                int x = int.Parse(Console.ReadLine());

                Console.WriteLine($"Введiть, будь ласка, координату точки-y {i + 1}:");
                int y = int.Parse(Console.ReadLine());

                points[i] = new Point(x, y, pointName);
            }

            Figure figure = new Figure(figureName, points);
            figure.PerimeterCalculator();
        }
    }
}
