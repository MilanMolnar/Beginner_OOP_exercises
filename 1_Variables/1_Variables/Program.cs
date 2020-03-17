using System;

namespace _1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Ben";
            int characterAge = 20;
            Console.WriteLine($"There was a man {characterName}");
            Console.WriteLine($"He was {characterAge}");
            characterName = "Mike";
            Console.WriteLine($"He hated the name {characterName}");
            Console.WriteLine($"But liked being {characterAge}");
        }
    }
}
