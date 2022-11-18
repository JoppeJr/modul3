namespace CodeAlong;

public class Lærer
{
    public string Name { get; set; }
    public int Modul { get; set; }

    public Lærer(string name, int modul)
    {
        Name = name;
        Modul = modul;
    }
}