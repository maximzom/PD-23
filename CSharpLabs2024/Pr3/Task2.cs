using System;
using Pr3_Points_And_Figure;

namespace Pr3
{
    public static class Task2
    {
        public static void Run()
        {
            Console.WriteLine("\nЗавдання №2.");
            Console.WriteLine("Потрiбно cтворити класи Point i Figure. Клас Point повинен мiстити два цiлочисельних поля та одне строкове поле.");
            Console.WriteLine("Створити три властивостi з одним методом доступу get. Створити користувацький конструктор, у тiлi якого");
            Console.WriteLine("проiнiцiалiзуйте поля значеннями аргументiв. Клас Figure повинен мiстити конструктори, якi приймають");
            Console.WriteLine("вiд 3-х до 5-ти аргументiв типу Point.");
            Console.WriteLine("Створити два методи: double LengthSide(Point A, Point B), який розраховує довжину сторони багатокутника;");
            Console.WriteLine("void PerimeterCalculator(), який розраховує периметр багатокутника.");
            Console.WriteLine("Написати програму, яка виводить на екран назву та периметр багатокутника.\n");

            Console.WriteLine("Введiть, будь ласка, кiлькiсть точок:");
            int pointsCount = Convert.ToInt32(Console.ReadLine());

            Point[] points = new Point[pointsCount];

            for (int i = 0; i < pointsCount; i++)
            {
                Console.WriteLine($"\nВведiть, будь ласка, координату X для точки {i + 1}:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nВведiть, будь ласка, координату Y для точки {i + 1}:");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nВведiть, будь ласка, назву точки {i + 1}:");
                string name = Console.ReadLine();

                points[i] = new Point(x, y, name);
            }

            Figure figure;

            switch (pointsCount)
            {

                case 3:
                    figure = new Figure(points[0], points[1], points[2]);
                    break;

                case 4:
                    figure = new Figure(points[0], points[1], points[2], points[3]);
                    break;

                case 5:
                    figure = new Figure(points[0], points[1], points[2], points[3], points[4]);
                    break;

                default:
                    Console.WriteLine("\nУвага! Неправильна кількість точок. Кількість точок має бути від 3 до 5.");
                    return;

            }

            figure.PerimeterCalculator();
        }
    }
}
