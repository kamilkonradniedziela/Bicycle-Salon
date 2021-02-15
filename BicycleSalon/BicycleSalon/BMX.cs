using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BicycleSalon
{
    class BMX : Bike
    {
        private string pegs;
        public override void SellBike() 
        {
            base.SellBike();
            Console.Write("Does your BMX have pegs?: "); pegs = Console.ReadLine(); Console.WriteLine();
        }

        public override void showBike()
        {
            base.showBike();
            Console.Write($"Does BMX have pegs: {pegs}"); 
        }

        public override void saveToFile(StreamWriter s)
        {
            base.saveToFile(s);
            s.Write($"Does BMX have pegs: {pegs}"); 
        }
    }
}
