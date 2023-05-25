using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrossesConsoleApp.GameSaving
{
    public class GameSaveModel
    {
        public int PlayersTurn { get; set; }
        public char[] PlayersSymbols { get; set; }
        public int[] PlayersScore { get; set; }
        public BoardSave Board { get; set; }
        public GameMode GameMode { get; set; }
        public GameSaveModel(int playersTurn,
            char[] playersSymbols, int[] playersScore, BoardSave board, GameMode gameMode)
        {
            PlayersTurn = playersTurn;
            PlayersSymbols = playersSymbols;
            PlayersScore = playersScore;
            Board = board;
            GameMode = gameMode;
        }
    }
    public class BoardSave
    {
        public char[] Board { get; set; }
        public BoardSave (char[] board)
        {
            Board = board;
        }
    }
}
