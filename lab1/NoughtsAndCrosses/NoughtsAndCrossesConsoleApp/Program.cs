using NoughtsAndCrossesConsoleApp;
using NoughtsAndCrossesConsoleApp.GameBoardOutput;
using NoughtsAndCrossesConsoleApp.GameLogics;

NoughtsAndCrosses game = new NoughtsAndCrosses(1, new char[] { 'X', 'O' }, new GameBoardClassic(), null, GameMode.Single);

if (args.Contains("--load-saved"))
    game.LoadSaved();

game.Start();