using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class vowel
    {
        static void Main(string[] args)
        {     
           
            Console.WriteLine("enter any character");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a'|| ch =='A')
            {
                Console.WriteLine(ch + "is vowel");

            }
           else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine(ch + "is vowel");
            }
            if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine(ch + "is vowel");
            }
            if (ch == 'o' || ch == 'O')
            {

                Console.WriteLine(ch + "is vowel");
            }
            if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine(ch + "is vowel");
            }
            else
            {
                Console.WriteLine("it is consonent");
            }
        }
    }
}
