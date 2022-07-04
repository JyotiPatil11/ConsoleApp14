using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class marks
    {
        static void Main(string[] args)
        {
            int total;
            float percentage;
            Console.WriteLine("enter the marks for the marathi:");
            int marathi = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marks for the english:");
            int english = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marks for the history:");
            int history = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marks for the hindi:");
            int hindi = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marks for the science:");
            int science = int.Parse(Console.ReadLine());

            total = marathi + english + history + hindi + science;
            percentage = (total / 500f) * 100;
            Console.WriteLine("total five subject=" + total);
            Console.WriteLine("percentage of five subject=" + percentage);

            if (percentage >= 70)
            {
                Console.WriteLine(" grade is  first class with distinaction");
            }
            else if (percentage >= 60 && percentage <=69)
            {
                Console.WriteLine(" grade is  first class");
            }
            else if (percentage >= 50 && percentage <= 59)
            {
                Console.WriteLine(" grade is second class");
            }
            else if (percentage >= 35 && percentage <= 49)
            {
                Console.WriteLine(" grade is pass");
            }
            else
            {
                Console.WriteLine(" grade is fail");
            }
        }





        
    }
}
