using System;

namespace _21_Inheretance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            ItalianChef italianChef = new ItalianChef();

            italianChef.MakePasta();
            chef.MakeChicken();
            Console.WriteLine("--------------Special----------------");
            chef.MakeSpecial();
            italianChef.MakeSpecial();

        }
    }
}
