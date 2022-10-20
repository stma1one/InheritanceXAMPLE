using InheritanceXAMPLE.Bagrut2022;
using System;

namespace Bagrut2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Antelope a1 = new Antelope(10);
            Object a2 = new Antelope(10);
            Beaver b1 = new Beaver(10); 
            Mammal b2 = new Beaver(10);

            //Console.WriteLine(a1.weight);
            //Console.WriteLine(((Beaver)a2).GetWeight());
            //Console.WriteLine(al.IsSame(a2));
            //Console.WriteLine(a2.IsSame(a1));
            //Console.WriteLine(b1.IsSame(b2));
            //Console.WriteLine(b2.IsSame(b1);
            //Console.WriteLine(a1.IsSame((Beaver)b2)); 
            //Console.WriteLine(a1.IsSame((Antelope)a2));
            //Console.WriteLine(b1.IsSame((Antelope)a2));
            //Console.WriteLine(b1.IsSame((Beaver)a2));

        }
    }
}
