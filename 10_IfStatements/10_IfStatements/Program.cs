using System;

namespace _10_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;
            if (isMale && isTall)
            {
                Console.WriteLine("Your male and tall.");
            }
            else
            {
                Console.WriteLine("Your are not a male or tall.");
            }
        }
    }
}
