namespace CodeAlong;

public class getAcademy
{
    public List<Student> studenter;
    public List<Lærer> Lærere;
    public KodeLås kodeLås;
    public bool erSkole;
    public string FargepåBygg;

    public getAcademy()
    {
        studenter = new List<Student>();
        Lærere = new List<Lærer>();
        kodeLås = new KodeLås();
        erSkole = true;
        FargepåBygg = "Hot Pink";
    }
    public void LeggTilLærere()
    {
        var lærer = new Lærer("Joakim", 3);
        var lærer2 = new Lærer("Linn", 1);

        Lærere.Add(lærer);
        Lærere.Add(lærer2);

    }
}