using System.Text;

namespace HotellMedGjester;

public class Gjest
{
    protected string _name;
    public int _romNr;
    public List<HotellRom> romListe = new List<HotellRom>();

    public Gjest(string name, HotellRom rom)
    {
        _name = name;
        _romNr = rom._romNr;
        romListe.Add(rom);
        
    }

    public Gjest(string name)
    {
        _name = name;
    }


    public override string ToString()
    {
        var gjest = _name + " bor på romnr: " + _romNr;
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(gjest);
        sb.AppendLine("Og står som eier av følgende rom: ");
        foreach (var hotellrom in romListe)
        {
            sb.AppendLine(hotellrom.ToString());
        }

        return sb.ToString();

    }
}