using System;

namespace _11_IfStatements_Compare_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10, 14));
            Console.WriteLine(GetGreatest(10, 13, 44));
            static int GetMax(int num1, int num2) 
            {
                int max = 0;
                if (num1 >= num2)
                {
                    max = num1;
                }
                else 
                { 
                    max = num2;
                }
                return max;
            }
            static int GetGreatest(int num1, int num2, int num3) 
            {
                int max = 0;
                if (num1 != num2 && num1 >= num3)
                {
                    max = num1;
                }
                else if (num2 >= num1 && num2 >= num3) 
                {
                    max = num2;
                }
                else
                {
                    max = num3;
                }
                return max;
            }
        }
    }
}
