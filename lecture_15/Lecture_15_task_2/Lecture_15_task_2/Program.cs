using System;

namespace Lecture_15_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            Console.WriteLine(str);
            
        }

        public static class StringExtention
        {
            public static string strOutput(string str)
            {
                string str1 = str.Substring(5);
                string str2 = "...";
                str = str1 + str2;
                return str;
            }
        }
    }
}
