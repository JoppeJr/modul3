using System;

namespace BerntLiver
{

    public class Opperation
    {
        private readonly Random randomnumb = new Random();
        private int numb = 0;
        private string userInput = "";
        private string PlayAgain = "y"; 



        private int SuccessRate => randomnumb.Next(1, 100);
        private bool SuccessCondition => numb > 50;
        private bool NotHappyWithOutcome => userInput == "n";
        private bool NotHappyWithOutcome2 => numb > 50;

        private bool NotHappyWithOutcome3 => userInput == "y";
        private bool NotHappyWithOutcome4 => numb < 50;
        private bool PlayMore => PlayAgain == "y";


        public void StartCheck()
        {
            while (PlayMore)
            {
                Console.WriteLine("Check if liver operation is a success");
                getSuccessRate();
                ShowSuccessRate();
                Console.WriteLine("Are you happy with outcome? y/n ?");

                userInput = Console.ReadLine();
                ChangedOutcome();
                Console.WriteLine("Check again? y/n");
                PlayAgain = Console.ReadLine();
            }
            



        }


        private void getSuccessRate()
        {
            numb = SuccessRate;
           
        }

        private void ShowSuccessRate()
        {

            if (SuccessCondition)
            {


                Console.WriteLine("you have a success! " + numb);
                return; 
            }

            
            Console.WriteLine("You died! " + numb);
                
            
        }

        private void ChangedOutcome()
        {
            if (NotHappyWithOutcome && NotHappyWithOutcome2 || NotHappyWithOutcome3  && NotHappyWithOutcome4)
            {
                Console.WriteLine("Oh Shit, you still died");
                return;
            }

            Console.WriteLine("Oh Shit, its a miracle the doctor managed to save you but now you are broke! ");

            

        }

    }
}