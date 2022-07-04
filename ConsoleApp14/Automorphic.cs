using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int square = (n * n);
            bool Condition = true;
            while(n>0)
            {
                if (n%10!=square%10)
                {
                    Condition = false;
                    break;
                }
                n = n / 10;
                square = square / 10;
            }
            if (Condition == true)
                Console.WriteLine("Automorphic");
            else
                Console.WriteLine(" not Automorphic");

        }
    }
    class Frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mobile number");
            long mb = long.Parse(Console.ReadLine());
            long temp = mb;
            for (int i=0;i<=9;i++)
            {
                int c = 0;
                //mb=0
                while(mb>0)
                {
                    long last = mb % 10;
                    if (last == i)
                        c++;

                    mb = mb / 10;
                }
                mb = temp;
                if (c > 0)
                    Console.WriteLine("Freq of " + i + " = " + c);
            }
        }
    }
    class class1
    {
        static void Main(string[] args)
        {
            //s=1!2!+3!+4!+......+n!

            Console.WriteLine("enter number of terms");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
             int fact = 1;
            for (int i=1;i<=n;i++ )
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            //n=45
            int sum =0;
            int a = n;
            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;
            }
            //sum =9
            if (a % sum == 0)
                Console.WriteLine("Harshad niven number");
            else
                Console.WriteLine("Not");

        }
    }
    class primeseries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
          
            int n = 27;
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not");
        }
    }
}
