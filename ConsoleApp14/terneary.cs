using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class terneary
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            
            string result =num % 2 == 0 ? "even" : "odd";
            Console.WriteLine(result);
            
        }
    }
}
