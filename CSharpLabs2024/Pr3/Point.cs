using System;

namespace Pr3_Points_And_Figure
{
    public class Point
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
}
