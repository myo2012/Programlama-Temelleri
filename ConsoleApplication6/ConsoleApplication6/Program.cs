using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {//girilen indisteki elamanı getirir.
        static void Main(string[] args)
        {
            int []a ={1,5,8,7,6};
            int indis;
            Console.WriteLine("indis noyu girin");
            indis = int.Parse(Console.ReadLine());
                if (indis>4)
                {Console.WriteLine("hatalı giriş");}
                    else 
                { Console.WriteLine(a[indis]);}
            Console.ReadLine();

        }
    }
}
