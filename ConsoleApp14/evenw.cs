using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class evenw
    {
        static void Main(string[] args)
        {
            int sum = 0, even = 0, odd = 0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int last = n % 10;
                if (last % 2 == 0)
                {
                    even = even + 1;
                }
                else
                {
                    odd = odd + 1;
                }
                sum = sum + last;
                n = n / 10;
            }
            Console.WriteLine("odd=" +even);
        }
    }
    class odd
    {
        static void Main(string[] args)
        {
            int sum = 0, even = 0, odd = 0;
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int i = n % 10;
                sum = sum + 1;
                n = n / 10;
                if (n % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

            }
            Console.WriteLine(sum);
            Console.WriteLine("even=" +even);
            Console.WriteLine("odd=" +odd);
        }
    }
    class Neon
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int square = 1;
            int last = 0;
            int n = int.Parse(Console.ReadLine());
            square = n * n;
            while(square>0)
            {
                last = square % 10;
                sum = sum + last;
                square = square / 10;

            }
            if (last ==n)
            {
                Console.WriteLine("Neon number");
            }
            else
            {
                Console.WriteLine("Neon number");
            }
        }
    }
    class palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            
            int temp = n;
            int reverse = 0;
            while(n>0)
            {
                int i = n % 10;
                reverse = reverse % 10 + 1;

                n = n / 10;

            }
            if (reverse == temp)
            {
                Console.WriteLine("palindrome");
            }
            else
                Console.WriteLine("not palindrome");
            
                

        }
    }
}
