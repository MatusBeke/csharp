using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public class Mesto
    {
        public string NazovMesta { get; set; }
        public List<Obcan> obcaniaList { get; set; }

        public Mesto()
        {

        }

        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            this.obcaniaList = new List<Obcan>();

        }


       public void PridajObcana (Obcan  obcan)
        { 
            obcaniaList.Add(obcan);
        }

        public void VypisObcanov()
        {

            foreach (var obcan in obcaniaList)
            {
                obcan.VypisInfo();

            }        
            Console.WriteLine("");
        }
    }
}
