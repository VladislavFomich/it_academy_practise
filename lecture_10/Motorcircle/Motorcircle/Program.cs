using System;

namespace Motorcircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcircle Minsk = new Motorcircle();
            Engine MinskEngine = new Engine();
            Minsk.model = Console.ReadLine();           
            Minsk.manufacturer = Console.ReadLine();
            Minsk.yearRelease = DateTime.Now.Year.ToString();
            Minsk.mileage = Convert.ToInt32(Console.ReadLine());
            MinskEngine.volume = Convert.ToInt32(Console.ReadLine());
            MinskEngine.power = Convert.ToInt32(Console.ReadLine());

            Motorcircle Honda = new Motorcircle();
            Engine HondaEngine = new Engine();
            Honda.model = Console.ReadLine();
            Honda.manufacturer = Console.ReadLine();
            Honda.yearRelease = DateTime.Now.Year.ToString();
            Honda.mileage = Convert.ToInt32(Console.ReadLine());
            HondaEngine.volume = Convert.ToInt32(Console.ReadLine());
            HondaEngine.power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Мотоцикл 1 - модель{Minsk.model}, проивз");
            Console.WriteLine();
        }
    }
}
