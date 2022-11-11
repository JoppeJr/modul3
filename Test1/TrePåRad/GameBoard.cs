using System;

namespace TrePåRad
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
            Content[position] = CellContent.Cross;

        }

        public void SetRanodomCircle()
        {
            var randomIndex = _random.Next(0, 8);
            while (Content[randomIndex] != CellContent.None)
            {
                randomIndex = _random.Next(0,8);
            }

            Content[randomIndex] = CellContent.Circle;
        }

        public bool ChechIfWin()
        {
            if(Content[0] == CellContent.Cross && Content[1] == CellContent.Cross && Content[2] == CellContent.Cross) return true;
            if (Content[0] == CellContent.Cross && Content[3] == CellContent.Cross && Content[6] == CellContent.Cross) return true;
            if (Content[0] == CellContent.Cross && Content[4] == CellContent.Cross &&
                Content[8] == CellContent.Cross) return true;
            else return false;

        }
    }
}