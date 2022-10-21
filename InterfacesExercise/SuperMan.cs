using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExercise
{
    internal class SuperMan:SuperHero,IFlyble
    {
        private string weakness;
        

        public SuperMan(string weakness):base("Clark Kent")
        {
            this.weakness = weakness;
        }

       

        public void Fly()
        {
            Console.WriteLine( "Fly like a BOSS");
        }


        public override void UsePowers()
        {
            base.UsePowers();
            Console.WriteLine("i can shoot LASER");
        }
    }
}
