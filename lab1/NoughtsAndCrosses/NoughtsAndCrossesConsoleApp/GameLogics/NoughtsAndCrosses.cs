using NoughtsAndCrossesConsoleApp.GameSaving;

namespace NoughtsAndCrossesConsoleApp.GameLogics
{
    public class NoughtsAndCrosses : GameModel
    {

        public NoughtsAndCrosses(int playersTurn, char[] playersSymbols, GameBoard board, int[] playersScore, GameMode gameMode) : base()
        {
            PlayersTurn = playersTurn;
            PlayersSymbols = playersSymbols;
            Board = board;
            PlayersScore = playersScore;
            GameMode = gameMode;            
        }

        public void Start()
        {
            GameMode prevMode = GameMode;
            GameMode = Board.ChooseGameMode();
            if (prevMode != GameMode)
                PlayersScore = null;
            RecentGameBoard = new char[Board.Board.Length];
            Array.Copy(Board.Board, RecentGameBoard, Board.Board.Length);

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, GameMode, LoadingException);
            if (LoadingException)
                LoadingException = false;

            PlayerMove = Board.ChooseCell();
            int gameProgress = Board.IsGameOver(PlayersSymbols);

            if (GameMode == GameMode.TwoPlayer)
            {
                do
                {
                    gameProgress = MakeMove(PlayerMove);
                } while (gameProgress == -1);
            }
            else
            {
                do
                {
                    if (PlayersTurn == 1)
                    {
                        gameProgress = MakeMove(PlayerMove);
                    }
                    else
                    {
                        gameProgress = GetAIMove();
                    }
                } while (gameProgress == -1);
            }


            if (gameProgress == 1)
                PlayersScore[0] += 1;
            else if (gameProgress == 2)
                PlayersScore[1] += 1;

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, GameMode, LoadingException);

            if (Board.GameOver(gameProgress, GameMode) == true)
            {
                Array.Reverse(PlayersSymbols);
                Board.SetDefaultBoard();
                Start();
            }

        }

        public int MakeMove(string cell)
        {
            int number;
            string exception = null;
            bool repeat = false;

            if (cell.ToLower() == "s" || cell.ToLower() == "save")
            {
                GameSave.Save(this);
            }
            else if (cell.ToLower() == "l" || cell.ToLower() == "load")
            {
                LoadSaved();
            }
            else if (cell.ToLower() == "u")
            {
                UndoMove();
                repeat = true;
            }
            else
            {
                if (int.TryParse(cell, out number) == false)
                    exception = "Please enter a valid number between 1 and 9.";
                else if (number < 1 || number > 9)
                    exception = $"There is no cell '{number}' on the field.";
                else if (Board.IsCellSet(number, PlayersSymbols))
                    exception = $"Cell '{number}' is already set.";

                if (exception == null)
                {                    
                    Array.Copy(Board.Board, RecentGameBoard, Board.Board.Length);
                    Board.SetGameCell(number, CurrentSymbol);
                    PlayersTurn = PlayersTurn == 1 ? 2 : 1;
                }
            }

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, GameMode, LoadingException);
            if (LoadingException)
                LoadingException = false;

            int gameOver = Board.IsGameOver(PlayersSymbols);
            if (gameOver != -1)
                return gameOver;
            if (GameMode == GameMode.TwoPlayer)
                PlayerMove = Board.ChooseCell(exception);
            else if(exception != null)
                PlayerMove = Board.ChooseCell(exception);
            if (repeat)
                PlayerMove = Board.ChooseCell(exception);
            return -1;
        }

        public int GetAIMove()
        {
            int number = GetBestMove(Board.Board);
            Board.SetGameCell(number + 1, CurrentSymbol);
            PlayersTurn = PlayersTurn == 1 ? 2 : 1;

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, GameMode, LoadingException);
            if (LoadingException)
                LoadingException = false;

            int gameOver = Board.IsGameOver(PlayersSymbols);
            if (gameOver != -1)
                return gameOver;
            PlayerMove = Board.ChooseCell();
            return -1;
        }


        public int GetBestMove(char[] board)
        {
            int bestScore = int.MinValue;
            int bestMove = -1;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] != PlayersSymbols[0] && board[i] != PlayersSymbols[1])
                {
                    char originalValue = board[i];
                    board[i] = PlayersSymbols[1];

                    int score = MiniMax(board, 0, false);

                    board[i] = originalValue;

                    if (score > bestScore)
                    {
                        bestScore = score;
                        bestMove = i;
                    }
                }
            }

            return bestMove;
        }

        private int MiniMax(char[] board, int depth, bool isMaximizingPlayer)
        {
            if (IsPlayerWinning(board, PlayersSymbols[1]))
                return 1;
            else if (IsPlayerWinning(board, PlayersSymbols[0]))
                return -1;
            else if (FindEmptyIndexes(board).Length == 0)
                return 0;


            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;

                for (int i = 0; i < board.Length; i++)
                    if (board[i] != PlayersSymbols[0] && board[i] != PlayersSymbols[1])
                    {
                        char originalValue = board[i];
                        board[i] = PlayersSymbols[1];

                        int score = MiniMax(board, depth + 1, false);

                        board[i] = originalValue;

                        bestScore = Math.Max(bestScore, score);
                    }

                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;

                for (int i = 0; i < board.Length; i++)
                    if (board[i] != PlayersSymbols[0] && board[i] != PlayersSymbols[1])
                    {
                        char originalValue = board[i];
                        board[i] = PlayersSymbols[0];

                        int score = MiniMax(board, depth + 1, true);

                        board[i] = originalValue;

                        bestScore = Math.Min(bestScore, score);
                    }
                return bestScore;
            }
        }

        private bool IsPlayerWinning(char[] board, char symbol)
        {
            if (
                (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
                (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
                (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                (board[2] == symbol && board[4] == symbol && board[6] == symbol)
                )
                return true;

            else
                return false;
        }

        private char[] FindEmptyIndexes(char[] board)
        {
            var arr = board.Where(c => !PlayersSymbols.Contains(c)).ToArray();
            return arr;
        }

        public void UndoMove()
        {
            if (GameMode == GameMode.TwoPlayer)
            {
                PlayersTurn = PlayersTurn == 1 ? 2 : 1;
            }
            Array.Copy(RecentGameBoard, Board.Board, Board.Board.Length);
            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, GameMode, LoadingException);
        }

        public void LoadSaved()
        {
            GameSaveModel saved = GameSave.LoadSaved();
            if (saved != null)
            {
                PlayersTurn = saved.PlayersTurn;
                PlayersSymbols = saved.PlayersSymbols;
                PlayersScore = saved.PlayersScore;
                Board.Board = saved.Board.Board;
            }
            else
                LoadingException = true;
        }
    }
}
