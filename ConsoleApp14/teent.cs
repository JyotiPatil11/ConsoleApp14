using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class teent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            string teen = age >= 13 && age <= 18 ? "teenager" : "no teenger";
            Console.WriteLine(teen);

        }
    }
}
