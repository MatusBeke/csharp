using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public class SeniorProgramator : Programator
    {
        public int  PocetProjektov {get; set;}
        public SeniorProgramator(string name, int age, string programovaciJazyk, int pocetJazykov) : base(name, age, programovaciJazyk, pocetJazykov){ }

    }
}
