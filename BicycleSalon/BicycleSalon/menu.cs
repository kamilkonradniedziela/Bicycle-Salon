using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleSalon
{
    class menu
    {
        public void showMenu()
        {
            Console.WriteLine("Welcome to bicycle salon!\nPick one option:");
            Console.WriteLine("1.Sell bike");
            Console.WriteLine("2.Buy bike");
            Console.WriteLine("3.Replace the bike");
            Console.WriteLine("4.Repair bike");
            Console.WriteLine("5.Show all salon's bikes");
            Console.WriteLine("6.Show Salon's budget");
            Console.WriteLine("7.Save list with bikes to the file");
            Console.WriteLine("8.Count all one brand bikes");
            Console.WriteLine("9.Quit the salon\n");
        }
    }
}
