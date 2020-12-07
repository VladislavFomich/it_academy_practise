using System;
using System.Collections.Generic;
using System.Text;

namespace Motorcircle
{
    internal class Motorcircle
    {
        public readonly int indeteficator;
        public string model;
        public string manufacturer;
        public string yearRelease;
        public int mileage;
       public void mileageInfo()
        {
            if(mileage > 100)
                Console.WriteLine("Ошибка, слишком большой пробег");
        }
    }
    class Engine : Motorcircle
    {
        public int volume;
        public int power;
    }
}
