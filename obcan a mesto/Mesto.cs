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

        public Mesto(string nazovMesta, List<Obcan> ObcaniaList)
        {
            NazovMesta = nazovMesta;
            this.obcaniaList = ObcaniaList;

        }
       /* public void PridajObcana (Obcan obcaniaList)
        {
            Console.WriteLine("Zadaj meno a vek obcana: ");
            var Name = Console.ReadLine();
            int Age = Int32.Parse(Console.ReadLine());


        }*/

        public void VypisObcanov()
        {
            foreach (var obcan in obcaniaList)
            {
                Console.WriteLine(obcan);
            }            
        }
    }
}
