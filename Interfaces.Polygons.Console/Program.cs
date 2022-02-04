using Interfaces.Polygons.Library;
using System;

namespace Interfaces.Polygons.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon(PolygonType.Square, square);

            var triangle = new Triangle(5);
            DisplayPolygon(PolygonType.Triangle, triangle);

            var octagon = new Octagon(5);
            DisplayPolygon(PolygonType.Octagon, octagon);

            Console.Read();
        }

        public static void DisplayPolygon(PolygonType polygonType, dynamic obj)
        {
            try
            {
                Console.WriteLine($"{polygonType.GetName()} ({polygonType.GetDescription()}) Number of Sides: {obj.NumberOfSides}");
                Console.WriteLine($"{polygonType.GetName()} ({polygonType.GetDescription()}) Side Length: {obj.SideLength}");
                Console.WriteLine($"{polygonType.GetName()} ({polygonType.GetDescription()}) Number Perimeter: {obj.GetPerimeter()}");
                Console.WriteLine($"{polygonType.GetName()} ({polygonType.GetDescription()}) Square Area: {obj.GetArea():#,0.00}");
                Console.WriteLine(string.Empty);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetFullMessage());
            }
        }
    }
}
