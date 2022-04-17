using System;
using System.ComponentModel.DataAnnotations;

namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        private const int Precision = 2;
        private const double Tolerance = 0.01;

        [Range(0.0, double.MaxValue)]
        private double _sideOne;
        [Range(0.0, double.MaxValue)]
        private double _sideTwo;
        [Range(0.0, double.MaxValue)]
        private double _sideThree;

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
            if (!IsPossible)
            {
                throw new ArgumentException("Triangle with these sides does not exist");
            }
        }

        public override double Area => Math.Sqrt(SemiPerimeter * (SemiPerimeter - _sideOne) * (SemiPerimeter - _sideTwo) * (SemiPerimeter - _sideThree));

        public override double Perimeter => _sideOne + _sideTwo + _sideThree;

        public bool IsPossible => (_sideOne + _sideTwo > _sideThree && _sideOne + _sideThree > _sideTwo && _sideTwo + _sideThree > _sideOne);

        public bool IsRightAngled
        {
            get
            {
                if (_sideOne >= _sideTwo && _sideOne >= _sideThree)
                {
                    return CheckIfTriangleIsRightAngled(_sideOne, _sideTwo, _sideThree);
                }

                if (_sideTwo >= _sideOne && _sideTwo >= _sideThree)
                {
                    return CheckIfTriangleIsRightAngled(_sideTwo, _sideOne, _sideThree);
                }

                if (_sideThree >= _sideOne && _sideThree >= _sideTwo)
                {
                    return CheckIfTriangleIsRightAngled(_sideThree, _sideOne, _sideTwo);
                }
                return false;
            }
        }

        private double SemiPerimeter => Perimeter / 2;

        private bool CheckIfTriangleIsRightAngled(double greatestSide, double sideTwo, double sideThree)
        {
            var x = Math.Abs(Math.Pow(greatestSide, 2) - ((Math.Pow(sideTwo, 2) + Math.Pow(sideThree, 2)))) ;
            if (Math.Abs(Math.Pow(greatestSide, 2) - ((Math.Pow(sideTwo, 2) + Math.Pow(sideThree, 2)))) < Tolerance)
            {
                return true;
            }

            return false;
        }

    }
}
