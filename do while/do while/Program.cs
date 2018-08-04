using System;
using System.Collections.Generic;
using System.Text;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayı = new Random();
            int a=0;
            int[] sayısal = new int[6];
            do
            {
              sayısal[a] = sayı.Next(1, 49);
              Console.WriteLine(sayısal[a]);
              a++;
            }
            while (a < 6);
            Console.ReadLine();
        }
    }
}
