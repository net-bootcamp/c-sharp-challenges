using System;
namespace Project
{
    abstract class ShippingDestination
    {
        public virtual decimal calcFees(decimal price) { return 0; }
        // This static method returns an actual ShippingDestination object
        // given the name of the destination, or null if none exists
        public static ShippingDestination getDestinationInfo(string dest)
        {
            if (dest == "zone1")
            {
                return new Dest_Zone1();
            }
            if (dest == "zone2")
            {
                return new Dest_Zone2();
            }
            if (dest == "zone3")
            {
                return new Dest_Zone3();
            }
            if (dest == "zone4")
            {
                return new Dest_Zone4();
            }
            return null;
        }
    }
    class Dest_Zone1 : ShippingDestination
    {
        public override decimal calcFees(decimal price)
        {
            return price * 0.25m;
        }
    }
    class Dest_Zone2 : ShippingDestination
    {
        public override decimal calcFees(decimal price)
        {
            return price * 0.12m;
        }
    }
    class Dest_Zone3 : ShippingDestination
    {
        public override decimal calcFees(decimal price)
        {
            return price * 0.08m;
        }
    }
    class Dest_Zone4 : ShippingDestination
    {
        public override decimal calcFees(decimal price)
        {
            return price * 0.04m;
        }
    }
    class Program
    {
        public delegate decimal ShippingFeesDelegate(decimal thePrice);
        static void Main(string[] args)
        {
            ShippingFeesDelegate theDel;
            ShippingDestination theDest;
            string theZone;
            do
            {
                Console.WriteLine("What is the destination zone?");
                theZone = Console.ReadLine();
                theDest = ShippingDestination.getDestinationInfo(theZone);
                if (theDest != null)
                {
                    Console.WriteLine("What is the item price?");
                    var itemPrice = decimal.Parse(Console.ReadLine());
                    theDel = theDest.calcFees;
                    decimal theFee = theDel(itemPrice);
                    Console.WriteLine("The shipping fees are: {0}", theFee);
                }
                else
                {
                    Console.WriteLine("Hmm, you seem to have entered an uknown destination. Try again or 'exit'");
                    if (Console.ReadLine().Equals("exit")) { break; }
                }
            } while (!theZone.Equals("exit"));
        }
    }
}
