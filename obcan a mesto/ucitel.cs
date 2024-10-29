using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    internal class ucitel
    {
    
       public string Meno { get; set; }
        public int vek { get; set; }

        public ucitel()
        {

        }

        public ucitel(string meno, int vek)
        {
            Meno = meno;
            vek = vek;
        }
        public void VypisInfo()
        {
            Console.WriteLine("Meno" + Meno + ", Vek " + vek + ",sere dzeci.");
        }
    }
}

