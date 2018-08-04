using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {/* 0dan 100e kadar olan sayılardan 
      5e bölünenleri yazan
      * for döngülü prog.*/
        static void Main(string[] args)
        {
            int a;
          for (a = 0; a <= 100; a++)
            {
                if (a % 5 == 0)
                    Console.WriteLine(a);
               }
               Console.ReadLine();
        }
    }
}
