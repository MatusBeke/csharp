using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
   class Programator : Obcan
    {
        public Programator(string name, int age) : base(name, age){ }
        public void VypisInfo()
        {
            Console.WriteLine("Meno" + Name + ", Vek " + Age + ", pise kodik.");
        }
    }
}

