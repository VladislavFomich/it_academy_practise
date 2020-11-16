using System;
using System.Linq;

namespace Lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
        }
        static void task1()
        {
           object[] emptyArray = new object[] { };
        }
        static void task2()
        {
           string[] myArray = new string[] {"32","A","Hello"};
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
           
        }
        static void task3()
        {
            int[] myArray = new int[13];
            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
               myArray[i] = rnd.Next();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Ваш массив: {myArray[i]}");
            }

            Console.WriteLine($"Максимальное значение массива {myArray.Max()}");
        }
        static void task4()
        {

        }
    }

}
