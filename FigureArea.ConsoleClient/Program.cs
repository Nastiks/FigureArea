using FigureArea.Calculator;
using FigureArea.Calculator.Figures;
using System;

namespace FigureArea.ConsoleClient
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                double input = 0;
                string output = "Выберите фигуру, площадь которой хотите рассчитать:\n1. круг;\n2. треугольник;\n3. другая.";

                Console.WriteLine(output);

                input = CheckTheInput(input, output);

                switch (input)
                {
                    case 1:
                        CircleProcessing();
                        break;

                    case 2:
                        TriangleProcessing();
                        break;

                    case 3:
                        FreeFifureProcessing();
                        break;
                    default:
                        Console.WriteLine("Выберите цифру от 1 до 3.");
                        break;
                }
            }
        }

        static void CircleProcessing()
        {
            Circle circle = new();
            string output = "Введите радиус круга: ";
            Console.Write(output);
            circle.Radius = CheckTheInput(circle.Radius, output);
            
            Console.WriteLine($"Площадь круга = {circle.Area}");
        }
        static void TriangleProcessing()
        {
            Triangle triangle = new();
            double[] arraySides = ListingOfParties();

            while (arraySides.Length != 3)
            {
                Console.WriteLine("Пожалуйста, введите 3 стороны.");
                arraySides = ListingOfParties();
            }

            triangle.SideA = arraySides[0];
            triangle.SideB = arraySides[1];
            triangle.SideC = arraySides[2];
            triangle.AreaTriangle = triangle.CalculatingTheArea();

            if (triangle.AreaTriangle == 0)
            {
                Console.WriteLine("Треугольника с такими сторонами не существует.");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника = {triangle.AreaTriangle}");
            }

            bool isRight = Helper.CheckForRightTriangle(arraySides);

            if (isRight)
            {
                Console.WriteLine("Треугольник прямоугольный.");
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный.");
            }
        }
        static void FreeFifureProcessing()
        {
            double[] arraySides = ListingOfParties();
            double area;

            switch (arraySides.Length)
            {
                case 1:
                    Console.WriteLine($"Площадь квадрата = {Math.Pow(arraySides[0], 2)}");
                    break;
                case 2:
                    area = arraySides[0] * arraySides[1];
                    Console.WriteLine($"Площадь фигуры = {Math.Round(area, 2)}");
                    break;
                case 3:
                    TriangleProcessing();
                    break;
                default:
                    Console.WriteLine("Расчёт площади правильного многоугольника...");
                    PolygonProcessing();
                    break;
            }

        }
        static void PolygonProcessing()
        {
            Polygon polygon = new();
            string output1 = "Введите количество сторон: ";
            Console.Write(output1);
            polygon.NumberOfSides = CheckTheInput(polygon.NumberOfSides, output1);
            string output2 = "Введите длину одной стороны: ";
            Console.Write(output2);
            polygon.SideA = CheckTheInput(polygon.SideA, output2);

            if (polygon.Area == 0)
            {
                Console.WriteLine("Правильного многоугольника с такими сторонами не существует.");
            }
            else
            {
                Console.WriteLine($"Площадь правильного многоугольника = {polygon.Area}");
            }
            Console.WriteLine($"Площадь правильного многоугольника = {polygon.Area}");
        }
        static double[] ListingOfParties()
        {
            Console.WriteLine("Введите длины сторон фигуры через пробел: ");

            string sides = Console.ReadLine();
            sides = sides.Replace('.', ',');
            string[] arrayInput = sides.Split();
            double[] arraySides = new double[arrayInput.Length];
            double area;
            try
            {
                for (int i = 0; i < arraySides.Length; i++)
                {
                    arraySides[i] = Convert.ToDouble(arrayInput[i]);
                }
            }
            catch
            {
                Console.WriteLine("Данные введены не верно.");
            }
            return arraySides;
        }
        static double CheckTheInput(double input, string output)
        {
            bool result = false;

            while (result != true)
            {
                if (!double.TryParse(Console.ReadLine(), out input) || input <= 0)
                {                    
                    Console.WriteLine("Ошибка ввода! Введите корректные данные.\nЕсли используете точку, замените её на запятую.");
                    Console.WriteLine(output);
                }
                else
                {
                    result = true;
                }
            }
            return input;

        }

    }
}