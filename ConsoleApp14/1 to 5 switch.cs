using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class _1_to_5_switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the between 1 to 5");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1: Console.WriteLine("One");
                break;

                case 2: Console.WriteLine("Two");
                break;

                case 3: Console.WriteLine("Three");
                break;

                case 4: Console.WriteLine("Four");
                break;

                case 5: Console.WriteLine("Five");
                break;

                default:
                    Console.WriteLine("Invalid number");
                    break;

                




            }
        }
    }
}
