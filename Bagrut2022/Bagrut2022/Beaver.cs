using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Bagrut2022
{
    internal class Beaver : Mammal
    {
        public Beaver(int w) : base(w) { }
        public override bool IsSame(Mammal other)
        {
            Console.WriteLine("In Beaver"); return ((other != null) && (other is Beaver) && (this.weight == ((Beaver)other).weight));

        }
    }
}
