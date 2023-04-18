using Newtonsoft.Json;
using NoughtsAndCrossesConsoleApp.GameLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrossesConsoleApp.GameSaving
{
    public class GameSave
    {
        private const string SaveFileName = "saved-game.json";
        private static string GetSaveFilePath()
        {
            return Directory.GetCurrentDirectory() + $"\\{SaveFileName}";            
        }

        public static void Save(GameModel game)
        {
            string saveFilePath = GetSaveFilePath();
            if (!File.Exists(saveFilePath))
                File.Create(SaveFileName);

            string output = JsonConvert.SerializeObject(game);
            File.WriteAllText(saveFilePath, output);
        }

        public static GameSaveModel LoadSaved()
        {
            string saveFilePath = GetSaveFilePath();
            if (!File.Exists(saveFilePath))
                return null;

            string json = File.ReadAllText(saveFilePath);
            if (JsonTryParse(json, out GameSaveModel game))
            {
                return game;
            }
            return null;
        }

        public static bool JsonTryParse<T>(string json, out T result)
        {
            bool success = true;
            var settings = new JsonSerializerSettings
            {
                Error = (sender, args) => { success = false; args.ErrorContext.Handled = true; },
                MissingMemberHandling = MissingMemberHandling.Error
            };
            result = JsonConvert.DeserializeObject<T>(json, settings);
            return success;
        }
    }
}
