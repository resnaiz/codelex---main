using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char currPlayer = 'X';

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();

            bool playGame = true;
            while(playGame)
            {
                Console.WriteLine("'" + currPlayer + "', choose your location (row/column):");
                var input = Console.ReadLine();
                var inputSplit = input.Split(' ');

                if(inputSplit.Length != 2)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (!int.TryParse(inputSplit[0], out int row) || !int.TryParse(inputSplit[1], out int collumn))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if(row < 0 || row > 2 || collumn < 0 || collumn > 2)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                if (board[row, collumn] != ' ')
                {
                    Console.WriteLine("Occupied!");
                    continue;
                }

                board[row, collumn] = currPlayer;
                DisplayBoard();

                if (CheckResult())
                {
                    if (board[row, collumn] == currPlayer)
                    {
                        Console.WriteLine(currPlayer + " is winner!");
                        break;
                    }
                }

                if(checkForTie())
                {
                    Console.WriteLine("The game is a tie!");
                    break;
                }

                currPlayer = (currPlayer == 'X') ? 'O' : 'X';
            }
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static bool CheckResult()
        {
            for(var r = 0; r < 3; r++)
            {
                if (board[r, 0] == currPlayer && board[r, 1] == currPlayer && board[r, 2] == currPlayer || board[0, r] == currPlayer && board[1, r] == currPlayer && board[2, r] == currPlayer)
                {
                    return true;
                }
            }

            if (board[0, 0] == currPlayer && board[1, 1] == currPlayer && board[2, 2] == currPlayer || board[0, 2] == currPlayer && board[1, 1] == currPlayer && board[2, 0] == currPlayer)
            {
                return true;
            }

            return false;
        }

        private static bool checkForTie()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var i = 0; i < 3; i++)
                {
                    if (board[r, i] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
