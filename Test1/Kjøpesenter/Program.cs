using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Kjøpesenter
 * butikker => produkter
 * kunder
 * anasatte
 * toaletter
 * lekeplass
 * infromasjon
 * innganger
 * parkerinksplasser
 *
 * minibank
 * 
 */

namespace Kjøpesenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kjøpesenter = new Kjøpesenter();
            

            
            
            
            
            while (true)
            {
                Console.WriteLine("Skriv Navn på butikk");
                var butikknavn = Console.ReadLine();
                var butikk = new Butikk(butikknavn);
                kjøpesenter.leggTilButikk(butikk);
                while (true)
                {
                    Console.WriteLine("Legg til produkter: VareNr 1234, VareNavn: XXXX, Pris: 1234");
                    var VareNummer = Convert.ToInt32(Console.ReadLine());
                    var VareNavn = Console.ReadLine();
                    var pris = Convert.ToInt32(Console.ReadLine());
                    var produkt = new Produkt(VareNummer, VareNavn, pris);
                    butikk.leggTilProdukt(produkt, VareNummer, VareNavn, pris);
                    Console.WriteLine("Ønsker du å legge til flere produkter? Y/N");
                    var answer1 = Console.ReadLine();
                    if (answer1 == "N" || answer1 == "n")
                    {
                        break;
                    }
                }
                
                Console.WriteLine("Ønsker du å legge til flere butikker? Y/N");
                var answer = Console.ReadLine();
                if (answer == "N" || answer == "n")
                {
                    break;
                }
            }
            
            kjøpesenter.SkrivUtAllInfo();
            Console.ReadLine();
        }
    }
}
