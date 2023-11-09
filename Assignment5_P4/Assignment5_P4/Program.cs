using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            int sum=0;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter numbers");
               arr[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }

            Console.WriteLine("sum:" + sum);
            Console.WriteLine("average:"+(sum/arr.Length));
        }
    }
}
