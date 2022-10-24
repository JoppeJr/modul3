using System;

namespace JokeGeneratorWMarEw
{
    public class OpptionsMenu
    {
        private ListOfJokes jokes = new();
        private PrintingMethods print = new();
        public void ExecuteOptions()
        {
            int Option = 0;
            do
            {
                print.Menu();
                try
                {
                    Option = int.Parse(Console.ReadLine());
                }
                catch { break; }
                if (Option == 1) { jokes.PrintDirtyJoke(); }
                if (Option == 2) { jokes.PrintFunnyJoke(); }
                if (Option == 3) { Environment.Exit(0); }
            }
            while (Option != 4);
        }
    }
}