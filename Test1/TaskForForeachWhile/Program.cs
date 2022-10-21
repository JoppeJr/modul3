using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForForeachWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Jester er kul " + (i + 1));
            }

            string text = "Jester er kul";

            foreach (var character in text)
            {
                Console.WriteLine(character);
            }

            bool shouldRun = true;
            int x = 0;
            while (shouldRun == true)
            {
                if (x > 8)
                {
                    shouldRun = false;
                }

                Console.WriteLine("Runde nummer: " + (x + 1));
                x++;
            }

            Console.ReadLine();
        }
    }
}
