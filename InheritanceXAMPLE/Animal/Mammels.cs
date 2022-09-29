using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Animal
{
    public class Mammels : Animals
    {

        private double milk;

        public Mammels(double milk, string type, double weight, string name) : base(type, weight, name)
        {
            this.milk = milk;
        }
        public Mammels(double milk)
        {
            this.milk = milk;
        }

        public Mammels()
        {

        }
        public void SetMilk(int milk)
        {
            this.milk = milk;
        }



    }
}
