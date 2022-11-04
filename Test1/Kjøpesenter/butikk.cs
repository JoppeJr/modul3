using System;
using System.Collections.Generic;

namespace Kjøpesenter
{
    public partial class Butikk
    {
        private string Navn { get; set; }
        public List<Produkt> produkter { get; set; }

        public List<Ansatte> ansatte { get; set; }

        public List<Dør> dører { get; set; }
        public Kasse kasse { get; set; }

        public Butikk(string navn)
        {
            Navn = navn;
            produkter = new List<Produkt>();
            ansatte = new List<Ansatte>();
            kasse = new Kasse();
            dører = new List<Dør>();
        }


        public void leggTilProdukt(Produkt produkt, int VareNr, string VareName, int Pris)

        {
            produkter.Add(produkt);
        }

        public void printButikkInfo()
        {
            for (int i = 0; i < produkter.Count; i++)
            {
               
                    Console.WriteLine(" Butikknavn: " + Navn + ": Produkt: " + produkter[i].HentProduktinfo());
            }
           
        }
    }
}