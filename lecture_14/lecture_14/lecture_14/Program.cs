using System;

namespace lecture_14
{
    class Program
    {
        struct Rectangle
        {
           public int height;
           public int width;
        }
        static void Main(string[] args)
        {
            int num = 0;
            Random rnd = new Random();
            Rectangle[] rectangles = new Rectangle[100];
            for (int i = 0; i < 100; i++)
            {
                rectangles[i].height = rnd.Next(1,10);
                rectangles[i].width = rnd.Next(1,10);
            }

            for (int i = 1; i < 100; i++)
            {
                if (rectangles[0].Equals(rectangles[i]))
                {
                    num++;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Ширина мaccива {i}: {rectangles[i].width},Длинна массива {rectangles[i].height}");
                
            }
            Console.WriteLine($"Количество дубликатов: {num}");
        }
    }
}
