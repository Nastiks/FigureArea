using System;

namespace FigureArea.Calculator.Figures
{
    public class Polygon
    {
        public double SideA;
        public double NumberOfSides;
        public double Area
        {
            get
            {
                double area = 0.25 * NumberOfSides * Math.Pow(SideA, 2) * Math.Tan(NumberOfSides / Math.PI); //Pentagon Area
                return Math.Round(area, 2);
            }
        }
    }

}