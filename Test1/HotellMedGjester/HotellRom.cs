namespace HotellMedGjester;

public class HotellRom
{
    public int _romNr;
    public bool _erLedig;

    public HotellRom(int romNr, bool erLedig)
    {
        _romNr = romNr;
        _erLedig = erLedig;
    }

    public override string ToString()
    {
        return "RomNr: " + _romNr + " Er ledig: " + _erLedig;
    }
    
}