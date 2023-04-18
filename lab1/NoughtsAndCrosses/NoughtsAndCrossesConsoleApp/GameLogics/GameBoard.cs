using Newtonsoft.Json;

namespace NoughtsAndCrossesConsoleApp.GameLogics
{
    public abstract class GameBoard
    {
        [JsonProperty]
        public char[] Board { get; set; }

        public GameBoard(char[] board)
        {
            Board = board;
        }

        public GameBoard()
        {
            SetDefaultBoard();
        }

        public void SetDefaultBoard()
        {
            Board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public void SetGameCell(int numberOfCell, char symbol)
        {
            Board[numberOfCell - 1] = symbol;
        }

        public bool IsCellSet(int numberOfCell, char[] symbols)
        {
            return symbols.Contains(Board[numberOfCell - 1]);
        }

        public abstract void PrintBoard(char[] playersSymbols, int[] playersScore, int playersTurn, bool loadingException = false);
        public abstract string ChooseCell(string exception = null);
        public abstract bool GameOver(int result);

        public int IsGameOver(char[] symbols)
        {          

            //Rows
            bool res;
            if (res = Board[0] == Board[1] && Board[1] == Board[2])
            {
                return Array.IndexOf(symbols, Board[0]) + 1;
            }
            else if (Board[3] == Board[4] && Board[4] == Board[5])
            {
                return Array.IndexOf(symbols, Board[3]) + 1;
            }
            else if (Board[6] == Board[7] && Board[7] == Board[8])
            {
                return Array.IndexOf(symbols, Board[6]) + 1;
            }

            //Columns
            else if (Board[0] == Board[3] && Board[3] == Board[6])
            {
                return Array.IndexOf(symbols, Board[0]) + 1;
            }
            else if (Board[1] == Board[4] && Board[4] == Board[7])
            {
                return Array.IndexOf(symbols, Board[1]) + 1;
            }
            else if (Board[2] == Board[5] && Board[5] == Board[8])
            {
                return Array.IndexOf(symbols, Board[2]) + 1;
            }

            //Diagonals
            else if (Board[0] == Board[4] && Board[4] == Board[8])
            {
                return Array.IndexOf(symbols, Board[0]) + 1;
            }
            else if (Board[2] == Board[4] && Board[4] == Board[6])
            {
                return Array.IndexOf(symbols, Board[2]) + 1;
            }

            // Draw
            else if (Board[0] != '1' && Board[1] != '2' && Board[2] != '3' &&
                Board[3] != '4' && Board[4] != '5' && Board[5] != '6' &&
                Board[6] != '7' && Board[7] != '8' && Board[8] != '9')
            {
                return 0;
            }

            //Not Over
            else
            {
                return -1;
            }
        }        
    }
}
