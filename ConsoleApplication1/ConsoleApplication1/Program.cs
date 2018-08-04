using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {/*şans topu 1-34e kadar 5 sayı
          * 1-14e kadar 1 sayı atayıp
          * ekrana yazan program
          while ile döngü olacak*/
            Random sayi=new Random();
            int[] sans = new int[5];
            int a=0, b;
            while (a < 5)
            {
               sans[a] = sayi.Next(1, 34);
               Console.WriteLine(sans[a]);
               a++;
            }
            b = sayi.Next(1, 14);
            Console.WriteLine("+" + b);
            Console.ReadLine();
        }
    }
}
