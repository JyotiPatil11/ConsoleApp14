using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Arm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            int copy = n;

            while(n>0)
            {
                c++;
                n = n / 10;

            }
            n = copy;
            int sum = 0;
            while(n>0)
            {
                int i = n % 10;
                int P = (int)Math.Pow(1, c);
                    sum = (sum + P);
                n = n / 10;

            }
            if (sum == copy)
                Console.WriteLine("armstrong");

            else
                Console.WriteLine("not armstrong");

        }
    }
}
