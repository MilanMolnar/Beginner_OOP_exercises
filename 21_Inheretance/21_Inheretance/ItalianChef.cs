using System;
using System.Collections.Generic;
using System.Text;

namespace _21_Inheretance
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Italian chef makes pasta");
        }

        public override void MakeSpecial()
        {
            Console.WriteLine("The chef makes special pizza");
        }
    }
}
