using System;
using InheritanceXAMPLE.Animal;
using InheritanceXAMPLE.Vehicles;

namespace InheritanceXAMPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object is the parent of all classes. everything inherates from object...
            //it gives us ToString, and Equals
            object o = new object();
            
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Tesla(24);
            vehicles[1] = new Bike();
            vehicles[2] = new ElectricBike(4);

            for (int i = 0; i <vehicles.Length; i++)
            {
                
                Console.WriteLine(vehicles[i].Horn());

                if (vehicles[i] is Motor)
                    Console.WriteLine(vehicles[i]);

                #region if not using virutal and override
                //we need to check each cell which type of class it is using IS 
                //then we need to CAST to the proper type


                //if (vehicles[i] is Tesla)
                //{
                            /*
                             * if we use a reference variable 
                             * it will help us make our code more readble 
                             * (reduce the use of CASTING)
                             */ 
                //    Tesla tesla = (Tesla)vehicles[i];
                //    Console.WriteLine(tesla.Horn());
                //}
                //else if (vehicles[i] is Bike)
                //{
                //    Bike bike = (Bike)vehicles[i];
                //    Console.WriteLine(bike.Horn());
                //}
                //else if(vehicles[i] is ElectricBike)
                //{
                //    ElectricBike electricBike = (ElectricBike)vehicles[i];
                //    Console.WriteLine(electricBike.Horn());
                //}

            }


        }
    }
}
