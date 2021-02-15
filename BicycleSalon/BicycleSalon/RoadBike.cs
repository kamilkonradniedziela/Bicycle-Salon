using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BicycleSalon
{
    class RoadBike : Bike
    {
        private string execution;
        public override void SellBike()
        {
            base.SellBike();
            Console.Write("Is your bike made with full carbon?:");  execution = Console.ReadLine(); Console.WriteLine();
        }

        public override void showBike()
        {
            base.showBike();
            Console.Write($"Is bike made with full carbon: {execution}");
        }

        public override void saveToFile(StreamWriter s)
        {
            base.saveToFile(s);
            s.Write($"Is bike made with full carbon: {execution}");
        }
    }
}
