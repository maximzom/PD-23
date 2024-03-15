using System;

namespace Pr3_Points_And_Figure
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
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
            Console.WriteLine($"\nПериметр багатокутника = {perimeter}.");
        }
    }
}
