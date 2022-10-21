using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercise
{
    internal class SuperHero
    {
        protected string alias;//שם גיבור
        public SuperHero(string alias)
        {
            this.alias = alias;
        }

        public virtual void UsePowers()
        {
            Console.WriteLine("this is my super power:");
        }
    }
}
