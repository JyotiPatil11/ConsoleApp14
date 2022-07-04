using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class diviser
    {
        static void Main(string[] args)
        {           

             
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 10 == 0)
            {
                Console.WriteLine(" number is divisible by 10");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 10");
            }
            Console.ReadLine();
        }
    }
}
