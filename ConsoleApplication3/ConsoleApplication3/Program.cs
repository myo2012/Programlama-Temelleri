using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {/* 0dan 100e kadar olan sayılardan 
      5e bölünenleri yazan
      * while döngülü prog.*/
            int a=0;
            while (a <= 100)
            {
                 a++;
                if(a%5==0)
                    Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
