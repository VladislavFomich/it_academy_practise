using System;
using System.Diagnostics.CodeAnalysis;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            String word = Console.ReadLine();

            int letter = 0;

            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == 'a' | word[i] == 'а')
                    letter++;
            }
            Console.WriteLine($"Количество букв 'а' в веденном вам слове - {letter}");
        }
    }
}
