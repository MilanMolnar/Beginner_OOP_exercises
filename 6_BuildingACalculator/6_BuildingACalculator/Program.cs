using System;

namespace _6_BuildingACalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: " + (num1 + num2));
        }
    }
}
