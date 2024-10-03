using System;
using System.Data;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis text:");
            string text = Console.ReadLine();

            int length = SpocitajPismena(text);

            Console.WriteLine("Text je dlhy: " + text.Length + " pismen");

        }
            public static int SpocitajPismena(string text)
            {
               return text.Length;
            }
        //DU: spocita samohlasky aj rozlisovat mal=e a velke pismena
        }
    }
