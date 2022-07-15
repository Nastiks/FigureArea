using FigureArea.Calculator;
using FigureArea.Calculator.Figures;

namespace FigureArea.Tests
{
    public class Tests
    {
        [Test]
        public void TestExistingTriangle()
        {
            Triangle triangle = new();

            triangle.SideA = 12;
            triangle.SideB = 13;
            triangle.SideC = 14;

            double result = triangle.CalculatingTheArea();

            double expected = 72.31;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestNonexistentTriangle()
        {
            Triangle triangle = new();
            triangle.SideA = 1;
            triangle.SideB = 1;
            triangle.SideC = 4;

            double result = triangle.CalculatingTheArea();

            double expected = 0;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ExistingCircle()
        {
            Circle circle = new();
            circle.Radius = 14.7;
            double result = circle.Area;
            double expected = 678.87;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ExistingPolygon()
        {
            Polygon polygon = new Polygon();
            polygon.NumberOfSides = 7;
            polygon.SideA = 11.4;
            double result = polygon.Area;
            double expected = -294.64;

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void RightTriangle()
        {
            Triangle triangle = new ();
            double[] arraySides = { 12, 9, 15 };
            
            bool result = Helper.CheckForRightTriangle(arraySides);
            bool expected = true;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}