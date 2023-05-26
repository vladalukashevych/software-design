using NoughtsAndCrossesConsoleApp.ConsoleOutputDecorators;
using NoughtsAndCrossesConsoleApp.GameLogics;

namespace NoughtsAndCrossesConsoleApp.GameBoardOutput
{
    public class GameBoardClassic : GameBoard
    {
        public GameBoardClassic(char[] board) : base(board) { }

        public GameBoardClassic() : base() { }

        private void PrintHeader()
        {
            Console.WriteLine(" Welcome to Noughts And Crosses!\n");
        }
        public override void PrintBoard(char[] playersSymbols, int[] playersScore, int playersTurn, GameMode gameMode, bool loadingException = false)
        {
            Console.Clear();
            if (loadingException)
                ColorConsoleOutput.Print(" No saved game was found!\n", ConsoleColor.DarkYellow);

            PrintHeader();
            Console.WriteLine($" Player 1: {playersSymbols[0]} [{playersScore[0]}]");
            if (gameMode == GameMode.Single)             
                Console.WriteLine($" Computer: {playersSymbols[1]} [{playersScore[1]}]\n\n");            
            else 
                Console.WriteLine($" Player 2: {playersSymbols[1]} [{playersScore[1]}]\n\n");

                Console.WriteLine($" Player {playersTurn}'s turn. Select from 1 to 9 from the game board.\n\n");

            Console.WriteLine(
                $"  {Board[0]} | {Board[1]} | {Board[2]}\n" +
                " ---+---+----\n" +
                $"  {Board[3]} | {Board[4]} | {Board[5]}\n" +
                " ---+---+----\n" +
                $"  {Board[6]} | {Board[7]} | {Board[8]}\n"
                );
        }

        public override string ChooseCell(string exception = null)
        {
            if (exception != null)
                ColorConsoleOutput.Print($" \n {exception}\n", ConsoleColor.DarkYellow);
            else
                Console.WriteLine();
            Console.Write(" Choose cell ");
            string input = Console.ReadLine();

            return input;
        }

        public override bool GameOver(int result, GameMode gameMode)
        {
            if (result != 0)
            {
                if (gameMode == GameMode.Single && result == 2)
                    ColorConsoleOutput.Print($"\n Computer has won!", ConsoleColor.Magenta);
                else
                    ColorConsoleOutput.Print($"\n Player {result} has won!", ConsoleColor.Magenta);
            }
                
            else
                ColorConsoleOutput.Print("\n It's a draw!", ConsoleColor.Magenta);

            bool repeat = false;

            bool validInput = true;
            do
            {
                if (!validInput)
                    ColorConsoleOutput.Print("\n Invalid input.", ConsoleColor.DarkRed);
                ColorConsoleOutput.Print("\n Do you want to play again? (y/n)", ConsoleColor.DarkYellow);
                Console.Write(" ");
                string input = Console.ReadLine().ToLower();

                if (input == "y" || input == "yes")
                {
                    repeat = true;
                    validInput = true;
                }
                else if (input == "n" || input == "no")
                {
                    repeat = false;
                    validInput = true;
                }
                else
                {
                    validInput = false;
                }

            } while (!validInput);

            return repeat;
        }

        public override GameMode ChooseGameMode()
        {
            GameMode mode = GameMode.Single;
            bool validInput = true;
            do
            {
                Console.Clear();
                PrintHeader();
                if (!validInput)
                    ColorConsoleOutput.Print(" Invalid input.", ConsoleColor.DarkRed);
                Console.WriteLine("\n Choose the game mode:\n  1 - single\n  2 - two player");
                Console.Write("\n>> ");
                string input = Console.ReadLine();
                int inputNum;
                bool isNum = int.TryParse(input, out inputNum);

                if (!isNum)
                {
                    validInput = false;
                }
                else if (inputNum == 1)
                {
                    mode = GameMode.Single;
                    validInput = true;
                }
                else if (inputNum == 2)
                {
                    mode = GameMode.TwoPlayer;
                    validInput = true;
                }
                else
                {
                    validInput = false;
                }

            } while (!validInput);

            return mode;
        }
    }
}
