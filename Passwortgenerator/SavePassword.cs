using System.Collections.Generic;
using System.IO;

namespace Passwortgenerator
{
    public class SavePassword
    {
        public static void SaveFile(string savePassword)
        {
            List<string> saveList = new List<string>();
            saveList.Add(savePassword);

            Directory.CreateDirectory(@"C:\Users\funk\Desktop\MeinePasswörter");

            File.AppendAllLines(@"C:\Users\funk\Desktop\MeinePasswörter\Passwörter.txt", saveList);
        }

        public static string[] FileOutput()
        {
            string[] passwordArray = File.ReadAllLines(@"C:\Users\funk\Desktop\MeinePasswörter\Passwörter.txt");
            return passwordArray;
        }
    }
}