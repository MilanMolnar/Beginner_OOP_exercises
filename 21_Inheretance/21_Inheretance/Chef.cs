using System;
using System.Collections.Generic;
using System.Text;

namespace _21_Inheretance
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes sald");
        }
        public virtual void MakeSpecial()
        {
            Console.WriteLine("The chef makes special bbw rib");
        }
    }
}
