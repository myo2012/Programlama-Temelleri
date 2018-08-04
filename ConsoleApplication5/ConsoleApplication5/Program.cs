using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {// üç sayıyı sıralama
            int a, b, c;
            Console.WriteLine("1.sayıyı girin:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı girin:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("3.sayıyı girin:");
            c = int.Parse(Console.ReadLine());
            if (a>b&a>c)
            { if (b>c)
                Console.WriteLine("a>b>c");
            else Console.WriteLine("a>c>b");
            }
            else if (b > a & b > c)
            {
                if (a > c)
                    Console.WriteLine("b>a>c");
                else Console.WriteLine("b>c>a");
            }
            else if (c > a & c > b)
            {
                if (a > b)
                    Console.WriteLine("c>a>b");
                else Console.WriteLine("c>b>a");
            }
            Console.ReadLine();
        }
    }
}
