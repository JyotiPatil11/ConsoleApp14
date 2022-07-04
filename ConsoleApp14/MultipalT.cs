using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class MultipalT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string mult = number % 5 == 0 ? "number is multipal of 5" : "number is not multipal of 5";
              Console.WriteLine(mult);
        }
    }
}
