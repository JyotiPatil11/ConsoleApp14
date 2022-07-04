using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class spynumber
    {
        static void Main(string[] args)
        {
            int n = 289;
            int sum = 0;
            int mul = 1;
            while(n!=0)
            {
                int i = n % 10;
                sum = sum + 1;
                mul = mul * 1;
                n = n / 10;
            }
            if (sum == mul)
                Console.WriteLine("spy number");
            else
                Console.WriteLine("not spy number");
        }
    }
}
