// See https://aka.ms/new-console-template for more information
using CodeAlong;
namespace CodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var GetAcademy = new getAcademy();
            GetAcademy.kodeLås.Kodelås();
            GetAcademy.LeggTilLærere();
           //.WriteLine(GetAcademy.kodeLås.RiktigKode); <--- funker ikke :P 
            
            Console.WriteLine(GetAcademy.Lærere.Count);
        }


       
    }
}


// skriv inn kode

//1234

// gratulerer

//  getAcademy:
//          {
//              Studenter:[{ navn: "Erik", id: 345},{ navn: "Truls", id: 346},],
//              Lærere:[{ navn: "Joakim", Modul: 3},{ navn: "Linn", Modul: 1},],
//              Kodelås: { riktig: 1234, antallSiffer: 4},
//              Skole: true,
//              FargePåBygg: "Hot Pink",
//          },