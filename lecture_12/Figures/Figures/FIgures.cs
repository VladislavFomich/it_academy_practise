using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    abstract class Figures
    {   
        public abstract string FiguresArea();
        public abstract string ShapeName();
        public abstract string ClrType();

        public void ShowInfo()
        {
            Console.WriteLine(
                $"This is: {ShapeName()}\n" +
                $"Square is: {FiguresArea()}\n" +
                $"Clr Type is: {ClrType()}"
                );
            Console.WriteLine();

        }

      public class Square : Figures
        {
            double side;

            public Square(double squareSide)
            {
                Side = squareSide;
            }

            public double Side
            {
                get { return side; }
                set { side = value < 0 ? -value : value; }
            }

            public override string FiguresArea()
            {
                return (side * side).ToString();
            }

            public override string ShapeName()
            {
                return "Квадрат";
            }
            public override string ClrType()
            {
                return "Figures.Square";
            }
        }

          public class Triangle : Figures
        {
            double sideA, sideB, sideC;

            public Triangle(double triangleSideA, double triangleSideB, double triangleSideC)
            {
                SideA = triangleSideA;
                SideB = triangleSideB;
                SideC = triangleSideC;
            }

            public double SideA
            {
                get { return sideA; }
                set { sideA = value < 0 ? -value : value; }
            }

            public double SideB
            {
                get { return sideB; }
                set { sideB = value < 0 ? -value : value; }
            }

            public double SideC
            {
                get { return sideC; }
                set { sideC = value < 0 ? -value : value; }
            }

            public override string FiguresArea()
            {
                double semPer = (sideA + sideB + sideC) / 2;
                return Math.Sqrt(semPer * (semPer - sideA) * (semPer - sideB) * (semPer - sideC)).ToString();
            }

            public override string ShapeName()
            {
                return "Треугольник";
            }

            public override string ClrType()
            {
                return "Figures.Triangle";
            }
        }

       public class Circle : Figures
        {
            const double pi = 3.14;
            double radius;

            public Circle(double circleRadius)
            {
                radius = circleRadius;
            }

            public double Radius
            {
                get { return radius; }
                set { radius = value < 0 ? -value : value; }
            }

            public override string FiguresArea()
            {
                return ((radius * radius) * pi).ToString();
            }

            public override string ShapeName()
            {
                return "Круг";
            }

            public override string ClrType()
            {
                return "Figures.Circle";
            }
        }
    }
}
