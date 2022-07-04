using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class factfor
    {
        static void Main(string[] args)
        {
            int num,fact=1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine(fact);
        }
    }
}
