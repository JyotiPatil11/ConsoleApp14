using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class switch_simlpe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("press 1=Add 2 = Subtract 3 = multiplication 4 = divide");
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Result :" + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Result :" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Result :" + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Result :" + (a / b));
                    break;
                default: Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}
