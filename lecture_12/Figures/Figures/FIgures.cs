using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    abstract class Figures
    {
       public int figuresSquare;
       public int side;
       public int radius;
       public int height;
       public const double pi = 3.14;
    }
       class Square : Figures
    {
         void SquareSquare()
        {
            int figuresSquare = side * side;
        }
    }
        class Triangle : Figures
    {
        void TriangleSquare()
        {
            int figuresSquare = side * side;
        }
   }
       class Circle : Figures
    {
        void CircleSquare()
        {
            double figuresSquare = pi * (radius * radius);
        }
    }
}
