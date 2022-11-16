using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EriksBossfight
{
    internal class Program
    {
        private static bool isGameRunning = true;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Bossfight!");
            
            var bossCharacters = new GameCharacters("Thomas The Daddy", 500, 16, 20);
            var heroCharacters = new GameCharacters("Odd William", 200, 36, 60);
            Console.WriteLine(bossCharacters._Name);
            Console.WriteLine(heroCharacters._Name);

            while (isGameRunning)
            {
                if (heroCharacters._stamina >= 10)
                {
                    heroAttack(heroCharacters, bossCharacters);
                }
                else
                {
                    Console.WriteLine(heroCharacters._Name + " Regharges stamina to full");
                    heroCharacters._stamina = 60;
                }

                if (bossCharacters._stamina >= 10 && isGameRunning == true)
                {
                    bossAttack(bossCharacters, heroCharacters);
                }

                else
                {
                    Console.WriteLine(bossCharacters._Name + " Regharges stamina to full");
                    bossCharacters._stamina = 20;
                }
            }
            Console.ReadLine();
        }

        private static void heroAttack(GameCharacters heroCharacters, GameCharacters bossCharacters)
        {
            Dividers();
            if (bossCharacters._health <= 0)
            {
                Console.WriteLine("Hero wins the fight! ");
                bossCharacters._health = 0;
                isGameRunning = false;

            }
            else
            {
                Console.WriteLine(heroCharacters._Name + " Attacks the boss! dealing: " + heroCharacters._dmg +
                                  " dmg. And cost 10 stamina");
                heroCharacters._stamina = heroCharacters._stamina - 10;
                heroCharacters._dmg = random.Next(10, 36);
                bossCharacters._health = bossCharacters._health - heroCharacters._dmg;
                Console.WriteLine(bossCharacters._Name + " Boss stats: Health: " + bossCharacters._health + " Stamina: " +
                                  bossCharacters._stamina);
            }
            
            Dividers();
            Thread.Sleep(2000);
            
        }

        private static void bossAttack(GameCharacters bossCharacters, GameCharacters heroCharacters)
        {
            Dividers();
            if (heroCharacters._health <= 0)
            {
                Console.WriteLine("Boss wins the fight! ");
                heroCharacters._health = 0;
                isGameRunning = false;
            }
            else
            {
                Console.WriteLine(bossCharacters._Name + " Attacks the hero! dealing: " + bossCharacters._dmg +
                                  " dmg. And cost 10 stamina");
                bossCharacters._stamina = bossCharacters._stamina - 10;
                bossCharacters._dmg = random.Next(0, 16);
                heroCharacters._health = heroCharacters._health - bossCharacters._dmg;
                Console.WriteLine(heroCharacters._Name + " Hero stats: Health: " + heroCharacters._health + " Stamina: " +
                                  heroCharacters._stamina);
            }
            Dividers();
            Thread.Sleep(2000);
            
        }

        private static void Dividers()
        {
            Console.WriteLine("*****************************************************************************");
        }
    }
}
