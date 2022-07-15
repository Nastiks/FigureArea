using System;

namespace FigureArea.Calculator.Figures
{
    public class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public double AreaTriangle;
        public double HalfMeter;

        public double CalculatingTheArea()
        {
            HalfMeter = (SideA + SideB + SideC) / 2;
            AreaTriangle = Math.Sqrt(HalfMeter * (HalfMeter - SideA) * (HalfMeter - SideB) * (HalfMeter - SideC));
            AreaTriangle = Math.Round(AreaTriangle, 2);

            return AreaTriangle > 0 ? AreaTriangle : 0;
        }
       
    }

}