using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check two numbers");

            var numb1 = Convert.ToInt32(Console.ReadLine());
            var numb2 = Convert.ToInt32(Console.ReadLine());
            if (numb1 == numb2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.WriteLine("Add unlike and multiply like numbers");
            Console.WriteLine(Task2());

            

            Task3();
        }

        static string Task3()
        {
            Console.WriteLine("check if value = 30");
            var numb5 = Convert.ToInt32(Console.ReadLine());
            var numb6 = Convert.ToInt32(Console.ReadLine());
            if (numb5 == 30 || numb6 == 30 || numb5 + numb6 == 30)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            return 
            Console.ReadLine();
        }

        static int Task2()
        {
            var numb3 = Convert.ToInt32(Console.ReadLine());
            var numb4 = Convert.ToInt32(Console.ReadLine());

            if (numb3 == numb4)
            {
                return numb3 * numb4;
            }
            
            
            return numb3 + numb4;

            

            
        }
    }
}
