using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Bagrut2022
{
    internal class Antelope : Mammal
    {
        public Antelope(int w) : base(w) { }
        public bool IsSame(Antelope other)
        {
            Console.WriteLine("In Antelope"); return ((other != null) && (this.weight == other.weight));

        }
    }
}
