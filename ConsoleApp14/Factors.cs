using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            int n = 12;
            int c = 0;
            for (int i = 1; i <= n; i++)

            {


                if (n % i == 0)
                {
                    Console.WriteLine("Factore=" + i);
                    c++;
                }
            }
            Console.WriteLine("Count=" + c);
        }
    }
}
