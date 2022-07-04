using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class teenger
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age>=13 && age <= 19)
            {
                Console.WriteLine("person is teen age");
            }
            else
            {
                Console.WriteLine("person is  not teen age");
            }
        }
    }
}
