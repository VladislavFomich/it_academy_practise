using System;
using System.Collections;

namespace lecture14.Task2.Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            
            arrayList.Add(45);//int  boxing
            arrayList.Add(true);//bool  boxing
            arrayList.Add("Hello!");//string false
            arrayList.Add(23.45);//double boxing

        }
    }
}
