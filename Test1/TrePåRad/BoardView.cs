using System;

namespace TrePåRad
{
    public class BoardView
    {
        public static void Show(GameBoard gameBoard)
        {
            Console.Clear();
            var content = gameBoard.Content;
            Console.WriteLine("  a b c  ");
            Console.WriteLine(" ┌─────┐");
            ShowOneLine(0, content);
            ShowOneLine(3, content);
            ShowOneLine(6, content);
            Console.WriteLine(" └─────┘");
        }

        private static void ShowOneLine(int startIndex, CellContent[] content)
        {
            var lineNo = 1 + startIndex / 3;
            
            Console.Write(lineNo + "|");
            for (var i = startIndex; i < startIndex + 3; i++)
            {
                if(i > startIndex)Console.Write(" ");

                var isBlank = content[i] == CellContent.None;
                var isCross = content[i] == CellContent.Cross;
                Console.Write(isBlank ? ' ' : isCross ? 'x' : 'o');

            }

            Console.WriteLine("|");
        }
    }
}