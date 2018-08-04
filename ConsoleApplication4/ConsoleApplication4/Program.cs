using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {/* girilen sayıya kadarki çift sayıları
          * ekrana yazdıran prog*/
            int a,b;
            Console.WriteLine("sayı girin:");
            a = int.Parse(Console.ReadLine());
            for (b = 0; b <= a; b++)
            {
                if (b % 2 == 0)
                    Console.WriteLine(b);
            }
            Console.ReadLine();

        }
    }
}
