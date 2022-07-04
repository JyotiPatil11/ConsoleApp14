using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class witouttT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            string teen = age >= 13 ? age <= 19 ? "teenager" : "no teenger" : " no teenger";

            Console.WriteLine(teen);
        }
    }
}
