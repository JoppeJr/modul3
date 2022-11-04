using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EriksBossfight
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bossfight!");
            
            var bossCharacters = new GameCharacters("Thomas The Daddy", 500, 8, 10);
            var heroCharacters = new GameCharacters("Odd William", 100, 24, 40);
            Console.WriteLine(bossCharacters._Name);
            Console.WriteLine(heroCharacters._Name);
            Console.ReadLine();
            fight();

        }

        private static void fight(object bossCharacters, object heroCharacter)
        {
            while(bossCharacters)
        }
    }
}
