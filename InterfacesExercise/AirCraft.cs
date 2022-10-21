using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercise
{
    internal class AirCraft
    {
        protected double speed;//מהירות
        protected string model;//סוג

        public AirCraft(double speed, string model)
        {
            this.speed = speed;
            this.model = model;
        }
    
        public virtual void Fly()
        {
        }
    }
}
