using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {




        static void Main(string[] args)
        {
            SayHi("Erik", 26);
            SayHi("Odd", 28);
            SayHi("William", 12);



            Console.ReadLine(); 
        }

        static void SayHi(string name, int age) // methods er nesten det samme som funksjoner. 
        {

            Console.WriteLine("Hello " + name + " You are " + age);  
        }



    }
}
