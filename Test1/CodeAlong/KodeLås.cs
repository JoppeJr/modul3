using System.Net.NetworkInformation;

namespace CodeAlong;

public class KodeLås
{
    private int RiktigKode = 1234;
    public int AntallSiffer = 4;

    public void Kodelås()
    {
        Console.WriteLine("Skriv inn kode:");
        var PinForsøk = Convert.ToInt32(Console.ReadLine());
        if (PinForsøk == RiktigKode)
        {
            Console.WriteLine("Velkommen inn til get!");
        }
        else
        {
            Console.WriteLine("Ha deg vekk herifra å lær deg kode.");
        }
    }
}