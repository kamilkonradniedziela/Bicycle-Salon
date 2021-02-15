using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BicycleSalon
{
    class CityBike : Bike
    {
        private string bicycleBasket;
        public override void SellBike()
        {
            base.SellBike();
            Console.Write("Does your city bike have basket?: "); bicycleBasket = Console.ReadLine(); Console.WriteLine();
        }

        public override void showBike()
        {
            base.showBike();
            Console.Write($"Does city bike have basket: {bicycleBasket}");
        }

        public override void saveToFile(StreamWriter s)
        {
            base.saveToFile(s);
            s.Write($"Does city bike have basket: {bicycleBasket}");
        }
    }
}
