using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guess_the_melody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuration;
        static public int musicDuration;
        static public bool randonStart = false;
        static public string lastFolder = "";
        static public bool AllDirectories = false;

        static public void ReadMusic()
        {
            string[] music_list = System.IO.Directory.GetFiles(lastFolder, "*.mp3",
                    AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_list);
        }
    }
}
