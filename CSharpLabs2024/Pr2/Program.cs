using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практична робота №2.");
            Console.WriteLine("Група - ПД-23.");
            Console.WriteLine("Виконав - Зелiнський Максим.\n");

            Console.WriteLine("Введiть, будь ласка, номер завдання (Вiд 1 до 4):");
            string taskNumber = Console.ReadLine();

            switch (taskNumber)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                case "3":
                    Task3();
                    break;

                case "4":
                    Task4();
                    break;

                default:
                    Console.WriteLine("Данного завдання не має у даннiй роботi.");
                    break;
            }
        }

        static void Task1()
        {
                Console.WriteLine("\nЗавдання №1.");
                Console.WriteLine("Написати програму. Дано три цiлих числа. Вибрати з них тi, якi належать iнтервалу [1,10 + N].");
                Console.WriteLine("Де N - остання цифра порядкового номеру у списку групи (У данному випадку - 6).");

                Console.WriteLine("\nВведiть, будь ласка, перше цiле число:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("\nВведiть, будь ласка, друге цiле число:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("\nВведiть, будь ласка, третє цiле число:");
                int c = int.Parse(Console.ReadLine());

                int listNumber = 6;
                int lowerLimitInterval = 1;
                int upperLimitInterval = 10 + listNumber;

                bool intervalCheckA = a >= lowerLimitInterval && a <= upperLimitInterval;
                bool intervalCheckB = b >= lowerLimitInterval && b <= upperLimitInterval;
                bool intervalCheckC = c >= lowerLimitInterval && c <= upperLimitInterval;

                Console.WriteLine("\nЧисла, якi належать iнтервалу [" + lowerLimitInterval + "," + upperLimitInterval + "]:");
                if (intervalCheckA) Console.WriteLine(a);
                if (intervalCheckB) Console.WriteLine(b);
                if (intervalCheckC) Console.WriteLine(c);
        }

        static void Task2()
        {
            Console.WriteLine("\nЗавдання №2.");
            Console.WriteLine("Написати програму. Дано три сторони трикутника. Обчислити периметр та площу трикутника.");
            Console.WriteLine("Визначити вид трикутника за сторонами. (потрIбно робити перевIрку на дIйснIсть трикутника");
            Console.WriteLine("та на коректнIсть введених даних).");

            Console.WriteLine("\nВведiть, будь ласка, сторону першої сторони трикутника:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВведiть, будь ласка, сторону другої сторони трикутника:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВведiть, будь ласка, сторону третьої сторони трикутника:");
            double c = double.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Значення були некоректно введені. Сторони трикутника повиннi бути бiльшi за 0.");
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("На жаль, цi значення не можуть утворити трикутник.");
                return;
            }

            double perimeterOfTriangle = a + b + c;
            double halfPerimeterOfTriangle = perimeterOfTriangle / 2;
            double findingOfAreaTriangle = Math.Sqrt(halfPerimeterOfTriangle * (halfPerimeterOfTriangle - a) * (halfPerimeterOfTriangle - b) * (halfPerimeterOfTriangle - c));

            Console.WriteLine($"\nПериметр трикутника: {perimeterOfTriangle} сантиметрiв.");
            Console.WriteLine($"Площа трикутника: {findingOfAreaTriangle} сантиметрiв квадратних.");

            if (a == b && b == c)
            {
                Console.WriteLine("Трикутник є рiвностороннiм.");
            }

            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Трикутник є рiвнобедреним.");
            }

            else
            {
                Console.WriteLine("Трикутник є рiзностороннiм.");
            }
        }

        static void Task3()
        {
            Console.WriteLine("\nЗавдання №3.");
            Console.WriteLine("Написати програму. Дано масив Х довжиною 10+N (де N - остання цифра студента у списку групи. У данному випадку - 6).");
            Console.WriteLine("Знайти мiнiмальне та максимальне значення. Вивести на екран масив та самi значення.");

            int listNumber = 6;
            int[] arrayOfTask = new int[10 + listNumber];
            Random incidentalNumbers = new Random();

            for (int i = 0; i < arrayOfTask.Length; i++)
            {
                arrayOfTask[i] = incidentalNumbers.Next(100);
            }

            int minSignificance = arrayOfTask[0];
            int maxSignificance = arrayOfTask[0];
            for (int i = 1; i < arrayOfTask.Length; i++)
            {

                if (arrayOfTask[i] < minSignificance)
                {
                    minSignificance = arrayOfTask[i];
                }

                if (arrayOfTask[i] > maxSignificance)
                {
                    maxSignificance = arrayOfTask[i];
                }
            }

            Console.WriteLine("\nМасив:");
            for (int i = 0; i < arrayOfTask.Length; i++)
            {
                Console.Write(arrayOfTask[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("\nМiнiмальне значення: " + minSignificance);
            Console.WriteLine("Максимальне значення: " + maxSignificance);

        }

        static void Task4()
        {
            Console.WriteLine("\nЗавдання №4.");
            Console.WriteLine("Написати програму. З масиву Х довжиною 10 + N  (де N - остання цифра студента у списку групи. У данному випадку - 6),");
            Console.WriteLine("серед елементiв якого є позитивнi та негативнi та нуль, сформуйте новий масив Y,");
            Console.WriteLine("узявши тiльки елементи з Х якi бiльше по модулю заданого числа М.");
            Console.WriteLine("Виведiть на екран число М та масиви заданий та отриманий.");

            int listNumber = 6;
            int[] X = new int[10 + listNumber];
            Random incidentalNumbers = new Random();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = incidentalNumbers.Next(-100, 101);
            }

            Console.Write("\nВведiть, будь ласка, число М: ");
            int M = int.Parse(Console.ReadLine());

            int[] Y = X.Where(x => Math.Abs(x) > M).ToArray();

            Console.WriteLine("\nЧисло М: " + M);
            Console.WriteLine("\nМасив X: " + string.Join(", ", X));
            Console.WriteLine("\nМасив Y: " + string.Join(", ", Y));

        }
    }
}

