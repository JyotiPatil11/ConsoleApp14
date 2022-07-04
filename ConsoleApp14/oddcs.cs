using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class oddcs
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter the value of :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(a%2==0)
            {
                Console.WriteLine(a + "no is even");
            }
            else
            {
                Console.WriteLine(b + "no is odd");
            }
        }
    }
}
