using System;

namespace _3_WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("z"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.Substring(8,3));
        }
    }
}
