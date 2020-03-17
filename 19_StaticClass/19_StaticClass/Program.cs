using System;

namespace _19_StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Greenday", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 220);
            Console.WriteLine(Song.songCount);
        }
    }
}
