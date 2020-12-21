using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_15_task_1
{
    class UniqueItem
    {
      public static int id;

        public void counter()
        {
           id = Convert.ToInt32(Console.ReadLine());
           id++;
            Console.WriteLine(id);
        }
    }
}
