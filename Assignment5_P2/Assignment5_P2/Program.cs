using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_P2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("for loop");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }

            //while
            Console.WriteLine("while loop");
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }
            Console.WriteLine("do while loop");
            int num = 1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
        }
    }
}
