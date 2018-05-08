using System;

namespace FactoryMethodPattern
{
    public class Point
    {
        private double _x, _y;

        private Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"Point > {nameof(_x)}:{_x} , {nameof(_y)}: {_y}";
        }

        public static class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point.Factory.NewCartesianPoint(1.0,2.0).ToString());
            Console.WriteLine(Point.Factory.NewPolarPoint(1.0, Math.PI/2).ToString());
            Console.ReadKey();
        }
    }
}
