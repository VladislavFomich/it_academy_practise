using System;
using System.Collections;

namespace lecture14.Task2.Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add(45);//int
            arrayList.Add(true);//bool
            arrayList.Add("Hello!");//string
            arrayList.Add(23.45);//double

        }
    }
}
