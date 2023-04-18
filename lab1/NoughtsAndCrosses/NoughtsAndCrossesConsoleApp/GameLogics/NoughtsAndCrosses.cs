using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NoughtsAndCrossesConsoleApp.GameSaving;

namespace NoughtsAndCrossesConsoleApp.GameLogics
{
    public class NoughtsAndCrosses : GameModel
    {

        public NoughtsAndCrosses(int playersTurn, char[] playersSymbols, GameBoard board, int[] playersScore) : base()
        {
            PlayersTurn = playersTurn;
            PlayersSymbols = playersSymbols;
            Board = board;
            PlayersScore = playersScore;
        }

        public void Start()
        {
            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, LoadingException);
            if (LoadingException)
                LoadingException = false;

            PlayerMove = Board.ChooseCell();
            int gameProgress = Board.IsGameOver(PlayersSymbols);

            do
            {
                gameProgress = MakeMove(PlayerMove);
            } while (gameProgress == -1);

            if (gameProgress == 1)
                PlayersScore[0] += 1;
            else if (gameProgress == 2)
                PlayersScore[1] += 1;

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, LoadingException);

            if (Board.GameOver(gameProgress) == true)
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

            if (cell.ToLower() == "s" || cell.ToLower() == "save")
            {
                GameSave.Save(this);
            }
            else if (cell.ToLower() == "l" || cell.ToLower() == "load")
            {
                LoadSaved();
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
                    Board.SetGameCell(number, CurrentSymbol);
                    PlayersTurn = PlayersTurn == 1 ? 2 : 1;
                }
            }

            Board.PrintBoard(PlayersSymbols, PlayersScore, PlayersTurn, LoadingException);
            if (LoadingException)
                LoadingException = false;

            int gameOver = Board.IsGameOver(PlayersSymbols);
            if (gameOver != -1)
                return gameOver;

            PlayerMove = Board.ChooseCell(exception);
            return -1;
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
