using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Kjøpesenter
{
    public class Kjøpesenter
    {
        public List<Butikk> Butikker { get; set; }
        public List<Kunde> Kunder { get; set; }

        public int Toaletter { get; set; }

        public List<Dør> Innganger { get; set; }

        public Lekeplass Lekeplass { get; set; }

        public int Parkeringsplasser { get; set; }

        public Info Info { get; set; }

        public Kjøpesenter()
        {
            Butikker = new List<Butikk>();
            Kunder = new List<Kunde>();
            Toaletter   = 8;
            Lekeplass = new Lekeplass();
            Innganger = new List<Dør>();
            Parkeringsplasser = 100;
            Info = new Info();


        }

        public void leggTilButikk(Butikk butikk)
        {
            Butikker.Add(butikk);
        }

        public void SkrivUtAllInfo()
        {
            foreach (var butikk in Butikker)
            {
                butikk.printButikkInfo();
            }
        }
        
    }
}