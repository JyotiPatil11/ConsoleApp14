using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class perimeter_rect
    {
        static void Main(string[] args)
        {
            int l = 5, w = 4, peri;

            Console.WriteLine("length of rect is " +l);
            Console.WriteLine("width of rect is " +w);

            peri = 2 * (l + w);
            Console.WriteLine("perimeter of rect" + peri);
            

        }
    }
}
