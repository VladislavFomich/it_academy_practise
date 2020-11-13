using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GoodDay
{
  public class Greeting
  {
    public static void GreetingClass()
    {
          string nowTime = DateTime.Now.ToString("HH:mm");
          Console.WriteLine(nowTime);

          int nowHours = Convert.ToInt32(DateTime.Now.ToString("HH"));          

          if(nowHours >= 9  &  nowHours <= 12)
              Console.WriteLine("Good morning, guys");
            
          else if (nowHours >= 12 & nowHours <= 15)
              Console.WriteLine("Good day, guys");

          else if (nowHours >= 15 & nowHours <= 22)
                  Console.WriteLine("Good evening, guys");

          else
              Console.WriteLine("Good night, guys");
    }
  }
}
