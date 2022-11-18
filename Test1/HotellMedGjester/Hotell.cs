using System.Security.Cryptography.X509Certificates;

namespace HotellMedGjester;

public class Hotell
{

    public List<Ansatt> Ansatte;
    public List<Gjest> hotellGjester;
    public List<HotellRom> Rom;  //har et gitt antall rom, uendret 

    public Hotell(List<HotellRom> allRom)
    {
        Rom = allRom;
        hotellGjester = new List<Gjest>();
    }

    public void PrintRomListe()
    {
        foreach (var hotellRom in Rom)
        {
            Console.WriteLine(hotellRom);
        }
    }

    public void SjekkInnGjest(string gjesteNavn)
    {
        
        var hotellrom = Rom.Find(x => x._erLedig);
        hotellGjester.Add(new Gjest(gjesteNavn, hotellrom));
        hotellrom._erLedig = false;

    }


    public void SjekkInnGjest(string gjesteNavn, List<Gjest> gjester)
    {
        var hotellrom = Rom.Find(x => x._erLedig);
        var NyHovedGjest = new Gjest(gjesteNavn, hotellrom);
        hotellGjester.Add(NyHovedGjest);
        hotellrom._erLedig = false;

        for (int i = 0; i < gjester.Count; i++)
        {
            hotellrom = Rom.Find(x => x._erLedig);
            NyHovedGjest.romListe.Add(hotellrom);
            gjester[i].romListe.Add(hotellrom);
            gjester[i]._romNr = hotellrom._romNr;
            hotellGjester.Add(gjester[i]);
            hotellrom._erLedig = false;
        }
       
    }

    public void PrintGjesteListe()
    {
        foreach (var gjest in hotellGjester)
        {
            Console.WriteLine(gjest);
        }
    }


}