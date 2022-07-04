using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class charswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'A':
                    Console.WriteLine("A");
                    break;

                case 'B':
                    Console.WriteLine("B");
                    break;

                case 'C':
                    Console.WriteLine("C");
                    break;

                case 'D':
                    Console.WriteLine("D");
                    break;

                case 'E':
                    Console.WriteLine("E");
                    break;

                default:
                    Console.WriteLine(" Invalid input");
                    break;
            }
        }
    }
}
