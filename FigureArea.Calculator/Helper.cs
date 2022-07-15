using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea.Calculator
{
    public static class Helper
    {
        public static bool CheckForRightTriangle(double[] arraySides)
        {
            double a = arraySides[0];
            double b = arraySides[1];
            double c = arraySides[2];
            bool pythagoreanTheorem = (a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a);

            return pythagoreanTheorem;
        }
    }
}
