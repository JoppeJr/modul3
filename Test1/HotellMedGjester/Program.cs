// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using HotellMedGjester;

namespace HotellMedGjester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var romListe = new List<HotellRom>();
            for (int i = 1; i <= 10; i++)
            {
                romListe.Add(new HotellRom(i, true));
            }
            var hotell = new Hotell(romListe);

            var gjest = new Gjest("Joakim");
            var gjest2 = new Gjest("Erik William");

            
            hotell.SjekkInnGjest("Papsen", new List<Gjest> { gjest, gjest2 });
            hotell.SjekkInnGjest("Trude");
            hotell.PrintGjesteListe();

            hotell.PrintRomListe();


        }
    }
}