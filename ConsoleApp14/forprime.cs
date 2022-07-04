using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{

    internal class forprime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0;

            for (int i=1;i<=n;i++)
            {
                  if (n%i==0)
                {
                    Console.WriteLine("Factor=" + i);
                    c++;
                }
            }
            if (c == 2)
                Console.WriteLine("prime");
            else
                Console.WriteLine("not prime");
        }
    }
}
