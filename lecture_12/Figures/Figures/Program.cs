using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures[] figures = new Figures[5];
            Figures figure1 = new Figures.Circle(1);
            Figures figure2 = new Figures.Triangle(1,2,3);
            Figures figure3 = new Figures.Square(5);
            Figures figure4 = new Figures.Circle(3);
            Figures figure5 = new Figures.Square(4);
            figures[0] = figure1;
            figures[1] = figure2;
            figures[2] = figure3;
            figures[3] = figure4;
            figures[4] = figure5;
            for (int i = 0; i < 5; i++)
            {
                figures[i].ShowInfo();
            }
        } 
    }
}
