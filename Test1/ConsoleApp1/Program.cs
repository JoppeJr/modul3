using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string tekst = "Get Academy";
            string navn = "Erik";
            char karakter = 'A';
            int alder = 26;
            double gjennomsnitt = 4.8;
            bool erMann = true;

            Console.WriteLine("Get\nAcademy\"");
            Console.WriteLine(tekst.ToUpper() + "\n" + navn.ToUpper() + " har fått karakter:" + karakter);

            Console.WriteLine( (5 + 8) * alder); // parantes gjør at det regnes ut først, bruker man int og desimal får man desimal svar, med bare int får man hele tall
            alder++; // øke alder med 1
            Console.WriteLine(alder); 
            Console.WriteLine( Math.Abs(-20));


            string characterName = "Odd";
            int characterAge = 28; 

            Console.WriteLine("Hei, jeg heter " + characterName);
            Console.WriteLine("han var " + characterAge);

            characterName = "Erik";
            characterAge = 26;

            Console.WriteLine("jeg likte navnet " + characterName);
            Console.WriteLine("men likte ikke å være " + characterAge);


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();    
            Console.WriteLine("Hello " + name + ", you are " + age + " years old");


            Console.ReadLine();




        }
    }



}