using System;
using System.Text.RegularExpressions;

namespace OppgaveTippeTolvKamper
{
    public class TwelveMatches
    {
        public Match[] Matches;

        public TwelveMatches()
        {
            Matches = new Match[12];
            
            GuessTwelveMatches();
        }

       

        public void GuessTwelveMatches()
        {
            var betsText = Console.ReadLine();
            var bets = betsText.Split(',');
            for (var i = 0; i < 12; i++)
            {
                Matches[i] = new Match(bets[i]);
            }
            while (true)
            {
                var command = IntroGuessScore();
                if (command == "X") break;
                var matchNo = Convert.ToInt32(command);
                var team = TypeGoalTeam(matchNo);
                var correctCount = IsGuessCorrect(matchNo, team);

                Console.WriteLine($"Du har {correctCount} rette.");
            }
        }

        private static string TypeGoalTeam(int matchNo)
        {
            Console.Write($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
            var team = Console.ReadLine();
            return team;
        }

        private int IsGuessCorrect(int matchNo, string team)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = Matches[selectedIndex];
            selectedMatch.AddGoal(team == "H");
            var correctCount = 0;
            for (var index = 0; index < Matches.Length; index++)
            {
                correctCount = IsBetCorrect(index, correctCount);
            }

            return correctCount;
        }

        private int IsBetCorrect(int index, int correctCount)
        {
            var match = Matches[index];
            var No = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            //var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {No}: {match.GetScore()} - {match.isBetCorrectText}");
            return correctCount;
        }

        private static string IntroGuessScore()
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine();
            return command;
        }
    }
}