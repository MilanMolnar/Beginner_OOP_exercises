using System;

namespace _13_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            Console.WriteLine(numberGrid[1,1]);
        }
    }
}
