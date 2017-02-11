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
        static public int gameDuration = 60;
        static public int timeforanswer = 10;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static string regKeyName = "Software\\MyCompany\\Guessthemelody";
        static public string answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] music_list = System.IO.Directory.GetFiles(lastFolder, "*.mp3",
                    allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                list.Clear();
                list.AddRange(music_list);
            }
            catch 
            {
            }          
        }

        public static void WriteParams()
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
                rk.SetValue("TimeForAnswer", timeforanswer);

            }
            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void ReadParams()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);

                if (rk != null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart"));
                    gameDuration = (int)rk.GetValue("GameDuration");
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    timeforanswer = (int)rk.GetValue("TimeForAnswer");
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
