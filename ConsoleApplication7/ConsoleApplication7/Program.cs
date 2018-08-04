using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {//sayısal loto programı
            Random sayı=new Random();
            int a;
            int[] sayısal = new int[6];
            for (a=0;a<6;a++)
            {
                sayısal[a] = sayı.Next(1, 49);
                Console.WriteLine(sayısal[a]);
            }
            Console.ReadLine();
            
            }

        }
    }

