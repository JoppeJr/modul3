namespace Kjøpesenter
{
    public class Produkt
    {
        public int VareNr;
        public string VareName;
        //public Størrelse størrelse;
        public int Pris;

        public Produkt(int vareNr, string vareName, int pris)
        {
            VareNr = vareNr;
            VareName = vareName;
            Pris = pris;
        }

        public string HentProduktinfo()
        {
            return " varenummer:  " + VareNr  + " Navn: "+  VareName + " Pris: " + Pris;
        }
        
    }
}