using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Circle
    {
        static void Main(string[] args)
        {
            int radius;
            double pi, area;
            radius = 4;
           pi  = 3.14;
            area = pi * radius * radius;
            Console.WriteLine("circle area =" + area);

        }
    }
}
