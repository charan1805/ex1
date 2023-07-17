using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    
    
        
      

namespace Day4_ex1
    {  
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Enter marks obtained in Pre:");
                int pre = int.Parse(Console.ReadLine());

                if (pre > 60)
                {
                    Console.WriteLine("Enter marks obtained in Finals:");
                    int final = int.Parse(Console.ReadLine());

                    if (final > 55)
                    {
                        Console.WriteLine("Selected");
                    }
                    else
                    {
                        Console.WriteLine("Fail in Finals");
                    }
                }
                else
                {
                    Console.WriteLine("Fail in Pre");
                }

                Console.ReadLine();

            }
        }
    }
}
    

