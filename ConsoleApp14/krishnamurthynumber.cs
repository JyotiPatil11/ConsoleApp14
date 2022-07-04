using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class krishnamurthynumber
    {
        static void Main(string[] args)
        {
            
            int n = 145;
            int sum = 0;
            int temp = n;
            while(n !=0)
            {
                
                int last= n % 10;
                int f = 1;
                for (int i =1;i<=last;i++)
                {
                    f = f * i;
                }
                sum = sum + f;
                n = n / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine("krishnamurthy number");
            }
            else
                Console.WriteLine("not krishnamurthy number");
        }
    }
}
