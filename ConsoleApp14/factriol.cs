using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class factriol
    {
        static void Main(string[] args)
        {
            int n = 12;
            for (int i=1;i<=n;i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine("Factore=" + i);

                }
            }
        }
    }
}
