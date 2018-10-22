using System;
using System.Runtime.InteropServices;

namespace Questions
{
    public static class Question2
    {
        public const string Title = "String manipulation (25 min)"; 

        public const string Instruction = "Ceate a function thats swop the blocks on the chessboard from Question 1 to start with 0,0 as black.  Print the output to a screen. Black blocks will labeled with 'b' and white blocks 'w'.";

        public const string Hint = "Use the output from the function in Question 1 as the source to the function you must write; do not simply copy and edit the function in Question 1.";

        public static void ReverseChessBoard()
        {
            var chessboard = new ChessBoard();
            chessboard.SwopTheBoard();

            Console.Write("--Test Completed--");
        }

        internal class ChessBoard
        {
            public int[,] Chessboard { get; private set; }

            public void SwopTheBoard()
            {
                Chessboard = Question1.GetChessboard();
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        if ((Question1.BlockColour)Chessboard[i, j] == Question1.BlockColour.Black)
                        {
                            Chessboard[i, j] = (int)Question1.BlockColour.White;
                        }
                        else
                        {
                            Chessboard[i, j] = (int)Question1.BlockColour.Black;
                        }

                    }
                }
                for (var i = 0; i < 8; i++)
                {
                    for (var j = 0; j < 8; j++)
                    {
                        Console.WriteLine((Question1.BlockColour)Chessboard[i, j] == Question1.BlockColour.Black ? "b" : "w"); 
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("--Test Completed--");
            }
        }
    }
}
