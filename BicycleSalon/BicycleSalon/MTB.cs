using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BicycleSalon
{
    class MTB : Bike
    {
        private string centralShockAbsorber;
        public override void SellBike()
        {
            base.SellBike();
            Console.Write("Does your MTB bike have central shock absorber?: "); centralShockAbsorber = Console.ReadLine(); Console.WriteLine();
        }

        public override void showBike()
        {
            base.showBike();
            Console.Write($"Does MTB have central shock absorber: {centralShockAbsorber}");
        }

        public override void saveToFile(StreamWriter s)
        {
            base.saveToFile(s);
            s.Write($"Does MTB bike have central shock absorber: {centralShockAbsorber}");
        }
    }
}
