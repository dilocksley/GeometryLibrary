using System;
using GeometryLibrary;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(3, 28.27)]
        [TestCase(14.5, 660.51986)]
        [TestCase(6.3, 124.68981)]
        [TestCase(0.9, 2.54469)]
        [TestCase(96, 28952.9179)]
        public void CircleAreaIsCalculatedCorrectlyTest(double radius, double expectedArea)
        {
            //Given
            var circle = new Circle(radius);

            //Then
            Assert.AreEqual(Math.Round(circle.Area, 2), Math.Round(expectedArea, 2));
        }

        [TestCase(3, 22)]
        [TestCase(14.5, 760)]
        [TestCase(6.3, 144)]
        [TestCase(0.9, 9)]
        [TestCase(96, 29952)]
        public void CircleAreaIsCalculatedCorrectlyNegativeTest(double radius, double expectedArea)
        {
            //Given
            var circle = new Circle(radius);

            //Then
            Assert.AreNotEqual(Math.Round(circle.Area, 2), Math.Round(expectedArea, 2));
        }

        [TestCase(3, 18.849552)]
        [TestCase(14.5, 91.106168)]
        [TestCase(6.3, 39.5840592)]
        [TestCase(0.9, 5.6548656)]
        [TestCase(96, 603.185664)]
        public void CirclePerimeterIsCalculatedCorrectlyTest(double radius, double expectedPerimeter)
        {
            //Given
            var circle = new Circle(radius);

            //Then
            Assert.AreEqual(Math.Round(circle.Perimeter, 2), Math.Round(expectedPerimeter, 2));
        }

        [TestCase(3, 19.849552)]
        [TestCase(14.5, 90.106168)]
        [TestCase(6.3, 31)]
        [TestCase(0.9, 7)]
        [TestCase(96, 611)]
        public void CirclePerimeterIsCalculatedCorrectlyNegativeTest(double radius, double expectedPerimeter)
        {
            //Given
            var circle = new Circle(radius);

            //Then
            Assert.AreNotEqual(Math.Round(circle.Perimeter, 2), Math.Round(expectedPerimeter, 2));
        }
    }
}