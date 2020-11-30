using System;

namespace Motorcircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcircle Minsk = new Motorcircle();
            Engine MinskEngine = new Engine();
            Console.WriteLine("Введите модель");
            Minsk.model = Console.ReadLine();
            Console.WriteLine("Введите производителя");
            Minsk.manufacturer = Console.ReadLine();
            Minsk.yearRelease = DateTime.Now.Year.ToString();
            Console.WriteLine("Введите пробег");
            Minsk.mileage = Convert.ToInt32(Console.ReadLine());
            Minsk.mileageInfo();
            Console.WriteLine("Введите обьем двигателя");
            MinskEngine.volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мощность двигателя");
            MinskEngine.power = Convert.ToInt32(Console.ReadLine());

            Motorcircle Honda = new Motorcircle();
            Engine HondaEngine = new Engine();
            Console.WriteLine("Введите модель");
            Honda.model = Console.ReadLine();
            Console.WriteLine("Введите производителя");
            Honda.manufacturer = Console.ReadLine();
            Honda.yearRelease = DateTime.Now.Year.ToString();
            Console.WriteLine("Введите пробег");
            Honda.mileage = Convert.ToInt32(Console.ReadLine());
            Honda.mileageInfo();
            Console.WriteLine("Введите обьем двигателя");
            HondaEngine.volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите мощность двигателя");
            HondaEngine.power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Мотоцикл 1 - модель-{Minsk.model}, производитель - {Minsk.manufacturer}, дата - {Minsk.yearRelease}, пробег - {Minsk.mileage}, обьем двигателя - {MinskEngine.volume}, мощность - {MinskEngine.power}");
            Console.WriteLine($"Мотоцикл 2 - модель-{Honda.model}, производитель - {Honda.manufacturer}, дата - {Honda.yearRelease}, пробег - {Honda.mileage}, обьем двигателя - {HondaEngine.volume}, мощность - {HondaEngine.power}");
        }
    }
}
