using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class average
    {
        static void Main(string[] args)
        {
            int marathi, hindi, english, history, maths;
            marathi = 75;
            hindi = 68;
            english = 80;
            history = 60;
            maths = 50;
            float avg;
            avg = (marathi + hindi + english + history + maths) / 5;
            Console.WriteLine(avg);
            
        }
    }
}
