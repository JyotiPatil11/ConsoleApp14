using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class patternI
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (r == 1 || c == 5 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class L
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || row == 5)
                        Console.Write("*");
                    else
                        Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
    class Tpat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c < +10; c++)
                {
                    if (c == 5 || r == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class P
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 5 || r == 1 || (r <= 5 && c == 10))
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class F
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 1 || r == 5)
                        Console.Write("F");
                }
                Console.WriteLine();
            }
        }
    }
    class X
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == r || r + c == 11)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
    class print1_5
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write(r);
                }

            }
            Console.WriteLine();

        }
    }
    class print2
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write(c);
                }

            }
            Console.WriteLine();
        }
    }
    class print3
    {
        static void Main(string[] args)
        {
            for (int r = 6; r >= 2; r--)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write(r);
                }
            }
            Console.WriteLine();
        }
    }
    class class4

    {
        static void Main(string[] args)
        {
            for (int r = 1; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class class5
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c % 2 == 0)
                        Console.Write("@");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
    class class6
    // 55555
    // 4444
    // 333
    // 22
    // 1
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
    // 6
    // 6 7
    // 6 7 8
    // 6 7 8 9
    class class6_1
    {
        static void Main(string[] args)
        {
            for (int r = 6; r >= 9; r++)
            {
                for (int c = 6; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    //1
    //1 2
    // 3 2 1
    // 4 3 2 1
    // 5 4 3 2 1
    class class5_1
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }


    class class7
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 5; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }


    class class8
    {
        static void Main(string[] args)
        {
            for (int r = 4; r >= 1; r--)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    class class9
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)

            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for (int r = 4; r >= 1; r--)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
            }
        }
    }
    /*
     A 
     AB
     ABC
     ABCD
     ABCDE
    */
    class classA
    {
        static void Main(string[] args)
        {
            for (char r = 'A'; r <= 'F'; r++)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    /*
    1
    10
    101
    1010
    10101

    0
    12
    345
    6789
    */

    class class10
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c % 2);

                }
                Console.WriteLine();
            }


        }
    }

    class classT1
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int r = 1; r <= 5; r++)
            {
                for (int space = 4; space >= r; space--)
                {
                    Console.Write(" ");

                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                k--;
            }
        }
    }
    /*
        *
        ***
        *****
        *******
        *********
      */
    class classp
        
    {
        static void Main(string[] args)
        {
         for (int r=1;r<=9;r++)
            {
                for (int c=1;c<=r;c++)
                {
                    if (r % 2 != 0)
                        Console.Write("*");
                    else
                        Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
    class classT2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of lines");
            int line = int.Parse(Console.ReadLine());

            for (int i=1;i<=line;i++)
            {
                for (int j = 1; j<2*i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    /*
              *
             ***
             *****
             *******
             ********
    */
    class classT3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of lines");
            int line = int.Parse(Console.ReadLine());

            for (int r = 1; r <= line; r++)
            {
                for (int sp=1;sp<=line-r;sp++)
                {
                    Console.Write(" ");
                }
                 for (int j = 1; j < 2 * r; j++)
                {
                    Console.Write("*");
                }
                 Console.WriteLine();

            }
        }
    }
    /*  
          1
          121
          12321
         1234321
         123454321
    */

    class classT4
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <=5; r++)
            {
                for (int sp = r; sp <=4; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; r <= r; c++)
                {
                    Console.Write(c);
                }
                for(int k =r- 1; k>=1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();

            }
        }
    }
}

