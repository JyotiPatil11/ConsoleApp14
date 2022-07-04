using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number for swapping");
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("the swaaped number" + a + "" + b);
        }
    }
}
