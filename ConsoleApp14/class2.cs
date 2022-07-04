using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class class2
    {
        static void Main(string[] args)
        {
            int n = 534;
            int sum = 0;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
