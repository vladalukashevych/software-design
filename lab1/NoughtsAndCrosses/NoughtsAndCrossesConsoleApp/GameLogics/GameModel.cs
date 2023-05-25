using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace NoughtsAndCrossesConsoleApp.GameLogics
{
    public class GameModel
    {
        private int playersTurn;
        [JsonProperty]
        public int PlayersTurn
        {
            get { return playersTurn; }
            set
            {
                if (value != 1 && value != 2)
                    playersTurn = 1;
                else
                    playersTurn = value;
            }
        }

        private char[] playersSymbols;
        [JsonProperty]
        public char[] PlayersSymbols
        {
            get { return playersSymbols; }
            set
            {
                if (value.Length != 2)
                    playersSymbols = new char[] { 'X', 'O' };
                else
                    playersSymbols = value;
            }
        }

        private int[] playersScore;
        [JsonProperty]
        public int[] PlayersScore
        {
            get { return playersScore; }
            set
            {
                if (value == null)
                    playersScore = new int[] { 0, 0 };
                else
                    playersScore = value;
            }
        }

        [JsonProperty]
        public GameBoard Board { get; set; }

        protected char CurrentSymbol
        {
            get { return PlayersSymbols[PlayersTurn - 1]; }
        }

        protected string PlayerMove { get; set; }
        protected bool LoadingException { get; set; }
        protected GameMode GameMode { get; set; }
        public char[] RecentGameBoard { get; set; }

        public GameModel()
        {
            
        }
    }
}
