using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class friendT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int your = int.Parse(Console.ReadLine());
            Console.WriteLine("enter friends  age");
            int friend  = int.Parse(Console.ReadLine());

            string age = friend > your ? "good morning" : friend < your ? "hi" : "how are you";
            Console.WriteLine(age);
        }
    }
}
