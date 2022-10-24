using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokeGeneratorWMarEw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var Run = new ListOfJokes();
            Run.ExecuteOptions();
            Console.ReadLine();


        }
    }

   
}
