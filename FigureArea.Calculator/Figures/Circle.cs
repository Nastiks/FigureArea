using System;

namespace FigureArea.Calculator.Figures
{
    public class Circle
    {
        public double Radius;
        public double Area
        {
            get 
            {
                double area = Math.PI * Math.Pow(Radius, 2);                
                return Math.Round(area, 2);
            }
        }
    }
}