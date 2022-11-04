using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTinaOgErik
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til PP med Tina the BOSS og Willi Wonka!");
            // hva skal vi gjøre ? - Erik er på oppgave bossfight og startet akkurat på den, ikke god på prosjekter i c#

            var IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine("Navn: ");
                var _Name = Console.ReadLine();

                Console.WriteLine("Skriv inn høyde: ");
                var _Height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Skriv inn alder: ");
                var _Age = Convert.ToInt32(Console.ReadLine());


                if (_Height >= 175 && _Age > 40)
                {
                    Console.WriteLine(_Name + " Du er høy og gammel! ");
                }

                else if (_Height >= 175 && _Age < 40)
                {
                    Console.WriteLine(_Name + " Du er høy og ung!");
                }
                else if (_Height < 175 && _Age < 40)
                {
                    Console.WriteLine(_Name + " Du er ung og lav! Muligheter for å vokse! ");
                }
                else
                {
                    Console.WriteLine(_Name + " Du er gammel og lav! Løpet er kjørt....");
                }
               

                Console.WriteLine("Check again? Y/N");
                var CheckAgain = Console.ReadLine();
                if (CheckAgain == "N" || CheckAgain == "n")
                {
                    IsRunning = false;
                }
                
            }

        }
    }
}
