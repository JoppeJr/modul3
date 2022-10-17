using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 7, 4, 35, 26, 28};
                                // 0  1  2   3    4

            luckyNumbers[1] = 15; // endrer value i applikasjonen

            string[] freinds = new string[5];
            freinds[0] = "Tom";
            freinds[1] = "Jerry";
            freinds[2] = "Mikke Mus";


            Console.WriteLine(luckyNumbers[3]);
            Console.WriteLine(freinds[0]);
            Console.WriteLine(freinds[1]);

            Console.ReadLine(); 
        }
    }
}
