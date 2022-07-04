using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class divisible3
    {
        static void Main(string[] args)
        {
            int a = 20;
            Console.WriteLine("enter number");
            
            int num = int.Parse(Console.ReadLine());
            if (a % 3 == 0 || a % 9 == 0)
            {
                Console.WriteLine("Number is divisible by 3 and 9" + a);
            }
            else
            {

                Console.WriteLine("Number is not divisible by 3 and 9 " + a);
            }
            Console.ReadLine();
        }
    }
}
