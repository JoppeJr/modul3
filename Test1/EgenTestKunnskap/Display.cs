using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace EgenTestKunnskap
{
    public class Display
    {
        private bool _enterProgram = true;
        private int _count;
        private List<ToDoList> ToDoLists { get; set; }

        public  Display()
        {
            ToDoLists = new List<ToDoList>();
            while (_enterProgram)

            {
                Console.Clear();
                Console.WriteLine("Dette er hoved menyen!");
                Console.WriteLine("Tast in din personlige kode for meny valg: ");
                var codelock = Convert.ToInt32(Console.ReadLine());
                if (codelock == 1234)
                {
                    
                    Rightcode();
                    ExitProgram();
                }
                else
                {
                    WrongCode();
                }

                ExitProgram();
            }
            
            
        }

        private static void WrongCode()
        {
            Console.WriteLine("du har tastet feil prøv igjen.");
            Console.WriteLine("Dette er hoved menyen!");
            Console.WriteLine("Tast in din personlige kode for meny valg: ");
        }

        private void ExitProgram()
        {
            Console.WriteLine("X. Exit program");
            var exit = Console.ReadLine();
            if (exit == "X" || exit == "x")
            {
                _enterProgram = false;
            }
        }

        private void Rightcode()
        {
            Console.Clear();
            MenuView();
            var optionsmenu = Convert.ToInt32(Console.ReadLine());
            if (optionsmenu == 1)
            {
                ShowToDos();
                Console.WriteLine("Tilbake til meny tast 1");
                var returnToMenu = Convert.ToInt32(Console.ReadLine());
                if (returnToMenu == 1)
                {
                    Rightcode();
                }
            }
            if (optionsmenu == 2)
            {
                AddToDoList(out var toDoText, out var toDoTime, out var addWanted);

                
            }

            if (optionsmenu == 3)
            {
                ShowToDos();
                Console.WriteLine("Trykk nummer for den tasken du ønsker å fjerne");
                var removeIndex = Convert.ToInt32(Console.ReadLine());
                ToDoLists.RemoveAt(removeIndex - 1);
                ShowToDos();

            }

            if (optionsmenu == 4)
            {
                var boardmodel = new GameBoard();
                var xWin = true;
                var BotWin = true;
                while (xWin || BotWin)
                {
                    BoardView.Show(boardmodel);
                    Console.Write("Skriv inn hvor du vil sette kryss (f.eks. 'a2' ): ");
                    var position = Console.ReadLine();
                    boardmodel.SetCross(position);

                    BoardView.Show(boardmodel);

                    Thread.Sleep(2000);
                    boardmodel.SetRanodomCircle();
                    xWin = boardmodel.ChechIfWin();
                    BotWin = boardmodel.CheckIfBotWin();
                    if (xWin == true)
                    {
                        Console.WriteLine("Gratulerer du har vunnet! ");
                        Thread.Sleep(2000);
                        Rightcode();

                    }

                    if (BotWin == true)
                    {
                        Console.WriteLine("Du har Tapt!");
                        Thread.Sleep(2000);
                        Rightcode();
                    }
                    else
                    {
                        xWin = true;
                        BoardView.Show(boardmodel);
                    }

                    Thread.Sleep(2000);
                }
            }
            else
            {
                Rightcode();
                ExitProgram();
            }


        }

        private static void MenuView()
        {
            Console.WriteLine("1. Se ToDoList");
            Console.WriteLine("2. Legg til toDolist");
            Console.WriteLine("3. Fjern fra toDoList");
            Console.WriteLine("4. Spill tic tac toe");
        }

        private void ShowToDos()
        {
            

                foreach (var ToDo in ToDoLists)
                {

                    Console.WriteLine("Task nr: " + _count + ToDo.ToString());
                    //Console.WriteLine("Task nr: " + i + ToDo.ToString());
                }
            
            
        }

       

        private void AddToDoList(out string toDoText, out int toDoTime, out string addWanted)
        {
            Console.WriteLine("Skriv inn gjøremål");
            toDoText = Console.ReadLine();
            Console.WriteLine("og dato for gjennomførelse:  format- 12012020");
            toDoTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du ønsker å legge til : " + toDoText + " Fullføres innen: " + toDoTime + "? y/n");
            addWanted = Console.ReadLine();
            if (addWanted == "N" || addWanted == "n")
            {
                Console.WriteLine("deleted to do. returning to menu.");
                Thread.Sleep(2000);
                Rightcode();
            }
            else
            {
                ToDoLists.Add(new ToDoList(toDoText, toDoTime, ToDoLists.Count+1));
                Console.WriteLine("du har lagt til i To do list.");
                Thread.Sleep(2000);
                Rightcode();
            }
        }
    }
}