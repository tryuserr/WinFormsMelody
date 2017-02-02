using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Guess_the_melody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration;
        static public int musicDuration;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static string regKeyName = "Software\\MyCompany\\Guessthemelody";

        static public void ReadMusic()
        {
            string[] music_list = System.IO.Directory.GetFiles(lastFolder, "*.mp3",
                    AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_list);
        }

        public static void WriteParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);

                if (rk == null) return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("AllDirectories", allDirectories);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParam()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("LastFolder"));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                }
                
            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}
