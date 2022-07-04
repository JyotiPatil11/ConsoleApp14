using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class greast
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the no");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            { 
                if (num1 > num3)
                {
                    Console.WriteLine("Number One is greatest");
                }
                else
                {
                    Console.WriteLine("Number Three is greatest");
                }
            }
            else if (num2 >num3)
            {
                Console.WriteLine(" Number Two is greatest");
            }
            else
            {
                Console.WriteLine(" Number Three is greatest");
            }

        }
    }
}
