using System;

namespace Interfaces.Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            SideLength = length;
            NumberOfSides = 8;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
