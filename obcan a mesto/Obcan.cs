﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obcan_a_mesto
{
    public class Obcan
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Obcan(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Obcan()
        {

        }

        public void VypisInfo() 
        {
            Console.WriteLine("Meno: " + Name + "Vek: " + Age);


        }
    }
}
