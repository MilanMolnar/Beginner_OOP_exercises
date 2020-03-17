using System;

namespace _4_WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(num));
            Console.WriteLine(Math.Pow(num, 2));
            Console.WriteLine(Math.Max(num, 1));
            Console.WriteLine(Math.Round(2.2));
        }
    }
}
