using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int i = int.Parse(Console.ReadLine());
            if (i%4==0)
            {
                Console.WriteLine("year is leap year");
            }
            else
            {
                Console.WriteLine("year is  not leap year");
            }
        }
    }
}
