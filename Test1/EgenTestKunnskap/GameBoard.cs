using System.Runtime.Remoting.Messaging;
using System;

namespace EgenTestKunnskap
{
    public class GameBoard
    {
        public bool IsGameRunning { get; set; }

        public CellContent[] Content { get; private set; }
        private Random _random;

        public GameBoard()
        {
            Content = new CellContent[9];
            _random = new Random();


        }

        public void SetCross(string positionStr)
        {
            var col = positionStr[0] == 'a' ? 0 : positionStr[0] == 'b' ? 1 : 2;
            var row = Convert.ToInt32(positionStr[1].ToString()) - 1;
            var position = row * 3 + col;
            if (Content[position] != CellContent.Circle)
            {
                Content[position] = CellContent.Cross;
            }
            
            

        }

        

        public void SetRanodomCircle()
        {
            var randomIndex = _random.Next(0, 8);
            while (Content[randomIndex] != CellContent.None)
            {
                randomIndex = _random.Next(0, 8);
            }

            Content[randomIndex] = CellContent.Circle;
        }

        public bool ChechIfWin()
        {
            int a1 = 0;
            int a2 = 3;
            int a3 = 6;

            if (Content[a1] == CellContent.Cross && Content[1] == CellContent.Cross && Content[2] == CellContent.Cross) return true;
            if (Content[a1] == CellContent.Cross && Content[a2] == CellContent.Cross && Content[a3] == CellContent.Cross) return true;
            if (Content[a1] == CellContent.Cross && Content[4] == CellContent.Cross && Content[8] == CellContent.Cross) return true;
            if (Content[1] == CellContent.Cross && Content[4] == CellContent.Cross && Content[7] == CellContent.Cross) return true;
            if (Content[2] == CellContent.Cross && Content[5] == CellContent.Cross && Content[8] == CellContent.Cross) return true;
            if (Content[2] == CellContent.Cross && Content[4] == CellContent.Cross && Content[8] == CellContent.Cross) return true;
            if (Content[a3] == CellContent.Cross && Content[7] == CellContent.Cross && Content[8] == CellContent.Cross) return true;

           
            else return false;

        }

        public bool CheckIfBotWin()
        {
            if (Content[0] == CellContent.Circle && Content[1] == CellContent.Circle && Content[2] == CellContent.Circle) return true;
            if (Content[0] == CellContent.Circle && Content[3] == CellContent.Circle && Content[6] == CellContent.Circle) return true;
            if (Content[0] == CellContent.Circle && Content[4] == CellContent.Circle && Content[8] == CellContent.Circle) return true;
            if (Content[1] == CellContent.Circle && Content[4] == CellContent.Circle && Content[7] == CellContent.Circle) return true;
            if (Content[2] == CellContent.Circle && Content[4] == CellContent.Circle && Content[6] == CellContent.Circle) return true;
            if (Content[2] == CellContent.Circle && Content[5] == CellContent.Circle && Content[8] == CellContent.Circle) return true;
            if (Content[6] == CellContent.Circle && Content[7] == CellContent.Circle && Content[8] == CellContent.Circle) return true;
            return false;
        }
    }
}