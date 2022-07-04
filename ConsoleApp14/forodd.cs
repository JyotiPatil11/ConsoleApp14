using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class forodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= 50; i++)
                if (i % 2 != 0)
                    Console.WriteLine("odd number is :" + i);

        }
    }
}
