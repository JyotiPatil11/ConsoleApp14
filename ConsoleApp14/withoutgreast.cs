using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class withoutgreast
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter three no");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1> num3)
            {
                Console.WriteLine(" the largest no is" + num1);
            }
            else if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine(" the largest no is" + num2);
            }
            else if  (num3 > num1 && num3 > num2)
           {
                Console.WriteLine(" the largest no is" + num3);
            }
        }
    }
}
