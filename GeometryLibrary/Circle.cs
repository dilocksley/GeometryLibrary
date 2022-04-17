using System;

namespace GeometryLibrary
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area => _radius * _radius * Math.PI;

        public override double Perimeter => _radius * Math.PI * 2;
    }
}
