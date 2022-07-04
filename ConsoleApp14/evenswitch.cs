using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class evenswitch
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the number");
            int i=  int.Parse(Console.ReadLine());
            int result = i % 2;

            switch ( result)
            {
                
                case 1: Console.WriteLine("Even");
                        break;


                default: 
                         Console.WriteLine("Odd");
                          break;


                    

            }



             
            
             

            

      
            

            
               
                
        }
    }
}
