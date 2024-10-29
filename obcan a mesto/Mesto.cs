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
        public List<Lekar> ListLekarov { get; set; }
        public List<Programator> listProgramatorov { get; set; }
        public List<ucitel> uciteliaList { get; set; }  


        public Mesto()
        {

        }

        public Mesto(string nazovMesta)
        {
            NazovMesta = nazovMesta;
            this.obcaniaList = new List<Obcan>();
            this.ListLekarov = new List<Lekar>();
            this.uciteliaList = new List<ucitel>();
            this.listProgramatorov = new List<Programator>();
        }

        public void PridajLekara (Lekar lekar)
        {
            ListLekarov.Add(lekar);
        }

        public void PridajProgramatora(Programator programator)
        {
            listProgramatorov.Add(programator);
        }
        public void PridajUcitela(ucitel ucitel)
        {
            uciteliaList.Add(ucitel);
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
