using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class positive
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());
            if (num> 0)
            {
                Console.WriteLine("positive");

            }
             else if (num<0)

            {
                Console.WriteLine("number is negative");

            }
               
       

        }
    }
}
