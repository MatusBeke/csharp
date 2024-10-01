using System;
using System.Drawing;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zadajcislo = Console.ReadLine();
            int konecnecislo = int.Parse(zadajcislo);

            int i = 0;
            while (i < konecnecislo)
            {
                Console.WriteLine(i);
                i++;  
            }
        }
    }
}
