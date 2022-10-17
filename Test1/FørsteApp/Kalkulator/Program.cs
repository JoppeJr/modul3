using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb1 + numb2);

            // må bruke ,(komma) når man skal skrive desimaler i console. . crasher appen. 
            Console.Write("Enter a number: ");
            decimal numb3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter another number: ");
            decimal numb4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(numb3 + numb4);
             

            Console.ReadLine();
        }
    }
}
