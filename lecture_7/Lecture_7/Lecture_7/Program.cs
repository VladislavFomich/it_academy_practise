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
           string[] emptyArray = new string[0];
        }
        static void task2()
        {
            int num = 32;   
            char symbal = 'A';
            string word = "Hello";
            object[] myArray = new object[3] { num, symbal, word };
            
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Ваш массив: {myArray[i]}");
            }

            int num2 = num + 10;
            myArray[0] = num2;
            string message = word + ", guys!";
            myArray[2] = message;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Ваш новый массив: {myArray[i]}");
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
            short num = 1;
            object obj = num;
            string str = "23";
            sbyte num2 = Convert.ToSByte(str);
        }
    }

}
