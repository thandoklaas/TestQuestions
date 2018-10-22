using System;

namespace Questions
{
    public static class Question1
    {
        public const string Title = "Arrays and Loops (25 min)";

        public enum BlockColour
        { 
            Black = 0,
            White = 1
        }

        public const string Instruction = 
            "Ceate a function that will build a chessboard that consists of black and white blocks starting with block 0,0 as white. Print the output to a screen. Black blocks will be labeled with 'b' and white blocks 'w'.";

        public static int[,] GetChessboard()
        {
            //create the chessboard using two dimensional array.
            var chessBoard = new int[8, 8];
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        chessBoard[i, j] = (int)BlockColour.White;
                    }
                    else
                    {
                        chessBoard[i, j] = (int)BlockColour.Black;
                    }
                }
            }
            return chessBoard;
        }
        public static void CreateChessBoard()
        {
            var chessBoard = GetChessboard();
            //iterate through the array and print output.
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    Console.WriteLine((BlockColour) chessBoard[i, j] == BlockColour.Black ? "b" : "w");
                }
                Console.WriteLine();
            }

        }

    }
}