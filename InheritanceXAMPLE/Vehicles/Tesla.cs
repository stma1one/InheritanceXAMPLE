using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Vehicles
{
    public class Tesla : Motor
    {
        const double ENGINE = 2.4;
        const int MAX_SPEED = 350;
       private  int chargingTime;
        public Tesla( int chargingTime) : base(ENGINE, MAX_SPEED, 4)
        {
            this.chargingTime = chargingTime;
        }

        public int GetChargingTime()
        {
            return chargingTime;
        }

        public void Ludicrous()
        {
            this.currentSpeed=MAX_SPEED;
        }
        public override string Horn()
        {
            return "VOOOM VOOOM";
        }

        //public override string ToString()
        //{
        //    return "I am Santa Claus";
        //}
    }
}
