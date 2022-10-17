using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are a tall male");
            }
            else if (isMale && !isTall) 
            { 
                Console.WriteLine("you are a short male");    
            }
            else if (!isMale && isTall) 
            { 
                Console.WriteLine("you are not a male but you are tall"); 
            }
            else 
            { 
                Console.WriteLine("you are not male or not tall");    
            }


            Console.ReadLine(); 
        }
    }
}
