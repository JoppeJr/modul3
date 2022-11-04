using System;

namespace OppgaveTippeTolvKamper
{
    public class Match
    {

        
            private int _homeGoals = 0;
            private int _awayGoals = 0;
            private string _bet;
            private bool _isRunning = true;
            public string isBetCorrectText { get; private set; }

            public Match(string bet)
            {
                _bet = bet;
            }
            //public void RunMatch()
            //{
            //    Intro();

            //    IsRunning();

            //    ResultatOgStop();
            //}

            //public void ResultatOgStop()
            //{
            //    var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            //    var isBetCorrect = _bet.Contains(result);
            //    var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            //    Console.WriteLine($"Du tippet {isBetCorrectText}");
            //    Console.ReadLine();
            //}

            //private void Intro()
            //{
            //    Console.Write(
            //        "Gyldig tips: \r\n - H, U, B\r\n - halvgardering: HU, HB, UB\r\n - helgardering: HUB\r\nHva har du tippet for denne kampen? ");
            //    _bet = Console.ReadLine();
            //}
            public void AddGoal(bool _IsHomeTeam)
            {
                if (_IsHomeTeam)
                {
                    _homeGoals++;
                }
                else
                {
                    _awayGoals++;
                }
            }


            public bool IsBetCorrect()
            {

            var result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
            var isBetCorrect = _bet.Contains(result);
            isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            return isBetCorrect;
        }

            public string GetScore()
            {
                return $"Stillingen er {_homeGoals}-{_awayGoals}.";
            }

        //private void IsRunning()
        //    {
        //        while (_isRunning)
        //        {
        //            Console.Write(
        //                "Kommandoer: \r\n - H = scoring hjemmelag\r\n - B = scoring bortelag\r\n - X = kampen er ferdig\r\nAngi kommando: ");
        //            var command = Console.ReadLine();
        //            _isRunning = command != "X";
        //            if (command == "H") _homeGoals++;
        //            else if (command == "B") _awayGoals++;
        //            Console.WriteLine($"Stillingen er {_homeGoals}-{_awayGoals}.");
        //        }
        //    }


        
    }
}