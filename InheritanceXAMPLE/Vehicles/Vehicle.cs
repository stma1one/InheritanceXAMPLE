using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Vehicles
{
    public class Vehicle
    {
        protected int maxSpeed;
        protected int currentSpeed;
        protected int tires;

        public Vehicle(int maxSpeed, int tires)
        {
            this.maxSpeed = maxSpeed;
            this.currentSpeed =0;
            this.tires = tires;
        }

        public int GetMaxSpeed()
        { return maxSpeed; }
        public int GetTires()
        { return tires; }

        public void SetCurrentSpeed(int speed)
        {
            currentSpeed = speed;
        }

        public int GetCurrentSpeed()
            { return currentSpeed; }

        public virtual string Horn()
        {
            return "Silence";
        }

      

    }
}
