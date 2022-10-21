using System;

namespace InterfacesExercise
{
    internal class Program
    {

        public static void WithOutUsingInterFace(object o)
        {
            //is it a Bird?
            if(o is Bird)
            {
                //we need to UNBOX (cast down from object) to Bird
                Bird bird = (Bird)o;
                bird.Fly();
            }
            //is it a Plane?
            if (o is Plane)
                {
                    //we need to UNBOX (cast down from object) to Plane
                    Plane plane = (Plane)o;
                    plane.Fly();
                }
                //no... It's SUPERMAN!
                else
                {
                //we need to UNBOX (cast down from object) to Superman
                   SuperMan superMan = (SuperMan)o;
                   superMan.Fly();
                   superMan.UsePowers();
                }
               


        }

        public static void WithInterface(IFlyble b)
        {
            if (b != null)
                b.Fly();
        }

        public static IFlyble[] FlybleThings()
        {
            return new IFlyble[3] { new SuperMan("Lex Luther"),new Bird(250,3,"Eagle"), new Plane(120,"747",450) };
        }
        static void Main(string[] args)
        {
            object ufo = new SuperMan("Kryptonite");
            WithOutUsingInterFace(ufo);
            WithInterface(ufo as IFlyble);

            #region Working with interfaces
            //WithInterface((IFlyble)ufo );

            //working with array
            IFlyble[] f = FlybleThings();
            foreach(IFlyble b in f)
            {
                b.Fly();
            }
            #endregion

            #region 0)What will Happen
            //IFlyble o=new IFlyble();
            #endregion

            #region 1)What will happen?
            //int number = 9;
            //IFlyble o = (IFlyble)number;
            #endregion

            #region 2)What will happen?
            //IFlyble o = ufo;
            //o.Fly();
            #endregion

            #region 3)What will Happen?
            // IFlyble o = (IFlyble)ufo;
            // o.Fly();
            #endregion

            #region 4)What will Happen?
            // IFlyble o = (IFlyble)ufo;
            // o.UsePowers();
            #endregion

            #region 5)What will Happen?
            //object o1 = "i an groot";
            //IFlyble o = (IFlyble)o1;
            //o.Fly();
            #endregion

            #region 6)What will Happen?
            // IFlyble o=(IFlyble)ufo;
            // SuperMan super=(SuperMan)o;
            // super.Fly();
            #endregion

            #region 7)What will Happen?
            //IFlyble o = (IFlyble)ufo;
            //Bird b = (Bird)o;
            //b.Fly();
            #endregion
        }
    }
}
