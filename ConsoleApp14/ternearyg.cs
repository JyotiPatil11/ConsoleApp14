using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class ternearyg
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2= int.Parse(Console.ReadLine());
            Console.WriteLine("enter third number");
            int num3 = int.Parse(Console.ReadLine());
            int temp = num1 > num2 ? num1 : num2;
            int max = num3 > temp ? num3 : temp;
        }
    }
}
