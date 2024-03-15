using System;

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
                    Task1.Run();
                    break;
                
                case "2":
                    Task2.Run();
                    break;
                
                default:
                    Console.WriteLine("Данного завдання не має у даннiй роботi.");
                    break;
            }
        }
    }
}
