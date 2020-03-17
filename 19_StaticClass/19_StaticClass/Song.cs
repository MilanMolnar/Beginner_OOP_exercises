using System;
using System.Collections.Generic;
using System.Text;

namespace _19_StaticClass
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;

        public Song(string Atitle, string Aartist, int Aduration)
        {
            title = Atitle;
            artist = Aartist;
            duration = Aduration;
            songCount++;
        }
    }
}
