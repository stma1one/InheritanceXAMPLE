using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercise
{
    internal class Plane:AirCraft,IFlyble
    {
        private double wingsLength;

        public Plane(double wingsLength,string model,double speed):base(speed,model)
        {
            this.wingsLength = wingsLength;
        }

        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("Take Off from runway");
        }
    }
}
