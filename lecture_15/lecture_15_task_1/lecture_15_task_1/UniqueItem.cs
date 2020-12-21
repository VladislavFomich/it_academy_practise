using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_15_task_1
{
    class UniqueItem
    {
        static int id = Convert.ToInt32(Console.ReadLine());
        int counterId = 0;

        UniqueItem()
        {
            id++;
            counterId = id;
        }
    }
}
