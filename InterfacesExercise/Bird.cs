using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercise
{
    internal class Bird:Animal,IFlyble
    {
        private double speed;
        private double wingsLength;

        public Bird(double speed, double wingsLength, string name):base(name)
        {
            this.speed = speed;
            this.wingsLength = wingsLength;
        }
        public void Fly()
        {
            Console.WriteLine("Fly like an Eagle");
        }
    }
}
