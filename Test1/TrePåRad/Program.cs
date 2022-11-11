using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrePåRad
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            var boardmodel = new GameBoard();
            var xWin = true;
            while (xWin)
            {
                BoardView.Show(boardmodel);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. 'a2' ): ");
                var position = Console.ReadLine();
                boardmodel.SetCross(position);
                BoardView.Show(boardmodel);

                Thread.Sleep(2000);
                boardmodel.SetRanodomCircle();
                xWin = boardmodel.ChechIfWin();
                if (xWin = true)
                {
                    Console.WriteLine("Gratulerer du har vunnet! ");
                    Thread.Sleep(5000);
                   
                }
                else
                {
                    xWin = true;
                    BoardView.Show(boardmodel);
                }
                
                Thread.Sleep(5000);
            }

            Console.ReadLine();
        }
    }
}
