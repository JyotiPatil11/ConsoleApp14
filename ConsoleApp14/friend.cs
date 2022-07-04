using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class friend
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your  friend age");
            int fage = int.Parse(Console.ReadLine());
            if (fage > myage)
            {
                Console.WriteLine("hi");
            }
            else if (myage > fage)
            {
                Console.WriteLine("good morning");
            }
            else
            {
                Console.WriteLine("how are you");
            }
        }
    }
}
