using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("fibonacii series");
            int a = 0;
            int b = 1;
            int c;
            Console.Write(a + " \n" + b + " \n");
            for (int i=2; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a =b;
                b = c;

               
            }
           
        }
    }
}
