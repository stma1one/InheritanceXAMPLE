using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Bagrut2022
{
    internal class Mammal
    {
        protected int weight;

        public Mammal(int weight)
        {
            this.weight = weight;
        }

        public int GetWeight()
        {
            return weight;
        }
        public virtual bool IsSame(Mammal other)
        {
            Console.WriteLine("In Mammal"); return (this == other);

        }
    }
}
