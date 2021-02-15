using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BicycleSalon
{
    class Bike
    {
        //private static int numberOfBike = 1;
        private string model;
        private int yearOfProduction;
        private string size;
        
        public string brand;
        public int price;



        virtual public void SellBike()
        {
            Console.Write("Price: ");   price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Brand: ");   brand = Console.ReadLine();
            Console.Write("Model: ");   model = Console.ReadLine();
            Console.Write("Year of production: ");  yearOfProduction = Convert.ToInt32(Console.ReadLine());
            Console.Write("Size of bike(XS/S/M/L/XL): "); size = Console.ReadLine();
        }


        public virtual void showBike()
        {
            //Console.WriteLine("Bike number " + numberOfBike++);
            Console.WriteLine($"Price: {price} PLN");
            Console.WriteLine("Brand: "+ brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year of production: "+ yearOfProduction);
            Console.WriteLine("Size of bike(XS/S/M/L/XL): " + size);
        }

        public virtual void saveToFile(StreamWriter s) 
        {
            s.WriteLine($"Price: {price} PLN");
            s.WriteLine("Brand: " + brand);
            s.WriteLine("Model: " + model);
            s.WriteLine("Year of production: " + yearOfProduction);
            s.WriteLine("Size of bike(XS/S/M/L/XL): " + size);
        }

    }
}
