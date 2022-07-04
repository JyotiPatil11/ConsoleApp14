using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class simplecs
    {
        static void Main(string[] args)
        {

            float p, t, r, i, a;
            Console.WriteLine("Enter the principle");
            p = float.Parse(Console.ReadLine());
            Console.WriteLine("the time period");
            t = float.Parse(Console.ReadLine());
            Console.WriteLine("the rate");
            r = float.Parse(Console.ReadLine());
            i = p * t * r / 100;
            Console.WriteLine("interest is" + i);
            a = p + i;
            Console.WriteLine("amount is" + a);
            Console.ReadLine();

        }
    }
}
