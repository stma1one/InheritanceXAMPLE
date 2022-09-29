using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Vehicles
{
    public class Bike : Bicycle
    {
        const int MAX_SPEED = 35;
        public Bike() : base(MAX_SPEED)
        {
        }

        public override string Horn()
        {
            return "Gling Glong";
        }
    }
}
