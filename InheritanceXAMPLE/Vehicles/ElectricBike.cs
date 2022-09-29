using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Vehicles
{
    public class ElectricBike : Bicycle
    {
        const int MAX_SPEED = 65;
        private int chargingTime;
        public ElectricBike(int chargingTime) : base(MAX_SPEED)
        {
            this.chargingTime = chargingTime;
        }

        public override string Horn()
        {
            return "Papum Papum";
        }
    }
}
