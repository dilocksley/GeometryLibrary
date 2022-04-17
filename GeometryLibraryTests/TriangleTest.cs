using System;
using GeometryLibrary;
using NUnit.Framework;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class TriangleTest
    {
        [TestCase(1, 2, 3)]
        [TestCase(11, 15, 30)]
        [TestCase(61, 29, 17)]
        public void TriangleCreationShouldThrowException(double sideOne, double sideTwo, double sideThree)
        {
            try
            {
                var triangle = new Triangle(sideOne, sideTwo, sideThree);
                Assert.Fail("Expected exception to be thrown.");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Triangle with these sides does not exist", ex.Message);
            }
        }

        [TestCase(3, 4, 5)]
        [TestCase(300, 400, 500)]
        [TestCase(12, 8, 8.94427)]
        [TestCase(3, 4, 2.64575)]
        [TestCase(12, 10.39230, 6)]
        public void IsTriangleRightAngled_ShouldReturnTrue(double sideOne, double sideTwo, double sideThree, bool expected = true)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreEqual(triangle.IsRightAngled, expected);
        }

        [TestCase(1, 3, 3)]
        [TestCase(7, 10, 12)]
        [TestCase(7, 10, 5)]
        [TestCase(11, 15, 20)]
        [TestCase(30, 25, 15)]
        public void IsTriangleRightAngled_ShouldReturnFalse(double sideOne, double sideTwo, double sideThree, bool expected = false)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreEqual(triangle.IsRightAngled, expected);
        }

        [TestCase(7, 10, 12, 34.977)]
        [TestCase(7, 10, 15, 29.393)]
        [TestCase(11, 15, 20, 81.39)]
        [TestCase(30, 25, 15, 187.082)]
        [TestCase(22, 19, 15, 140.199857)]
        public void TriangleAreaIsCalculatedCorrectlyTest(double sideOne, double sideTwo, double sideThree, double expectedArea)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreEqual(Math.Round(triangle.Area, 2), Math.Round(expectedArea, 2));
        }

        [TestCase(7, 10, 12, 36)]
        [TestCase(7, 10, 15, 22.393)]
        [TestCase(11, 15, 20, 84.39)]
        [TestCase(30, 25, 15, 186.082)]
        [TestCase(22, 19, 15, 140.9)]
        public void TriangleAreaIsCalculatedCorrectlyNegativeTest(double sideOne, double sideTwo, double sideThree, double expectedArea)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreNotEqual(Math.Round(triangle.Area, 2), Math.Round(expectedArea, 2));
        }

        [TestCase(7, 10, 12, 29)]
        [TestCase(7.336, 10.4635, 15.656, 33.46)]
        [TestCase(11, 15, 20, 46)]
        [TestCase(30, 25, 15, 70)]
        [TestCase(22, 19, 15, 56)]
        public void TrianglePerimeterIsCalculatedCorrectlyTest(double sideOne, double sideTwo, double sideThree, double expectedPerimeter)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreEqual(Math.Round(triangle.Perimeter, 2), Math.Round(expectedPerimeter, 2));
        }

        [TestCase(7, 10, 12, 29.5)]
        [TestCase(7.336, 10.4635, 15.656, 33)]
        [TestCase(11, 15, 20, 46.1)]
        [TestCase(30, 25, 15, 73)]
        [TestCase(22, 19, 15, 55)]
        public void TrianglePerimeterIsCalculatedCorrectlyNegativeTest(double sideOne, double sideTwo, double sideThree, double expectedPerimeter)
        {
            //Given
            var triangle = new Triangle(sideOne, sideTwo, sideThree);

            //Then
            Assert.AreNotEqual(Math.Round(triangle.Perimeter, 2), Math.Round(expectedPerimeter, 2));
        }
    }
}
