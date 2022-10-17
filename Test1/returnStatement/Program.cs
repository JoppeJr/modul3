using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cubedNumber = Cube(3);

            //Console.WriteLine(cubedNumber); denne funker og 

            Console.WriteLine(Cube(3)); // og denne funker.


            Console.ReadLine(); 
        }

        static int Cube(int numb) 
        {
            int result = numb * numb * numb;

            return result;
        }
    }
}
