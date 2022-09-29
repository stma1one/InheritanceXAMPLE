using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE.Vehicles
{
    public class Motor : Vehicle
    {
        protected double engineVolume;
        
        public Motor(double engineVolume,int maxSpeed, int tires) : base(maxSpeed, tires)
        {
            this.engineVolume = engineVolume;
        }

        public double GetEngineVolume() { return engineVolume; }

        public void Brake()
        {
            this.currentSpeed = 0;
        }
        public override string ToString()
        {
            return "I am Groot";
        }

    }
}
