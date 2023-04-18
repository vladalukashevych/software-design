using NoughtsAndCrossesConsoleApp.GameBoardOutput;
using NoughtsAndCrossesConsoleApp.GameLogics;

NoughtsAndCrosses game = new NoughtsAndCrosses(9, new char[] { 'X', 'O' }, new GameBoardClassic(), null);

if (args.Contains("--load-saved"))
    game.LoadSaved();

game.Start();