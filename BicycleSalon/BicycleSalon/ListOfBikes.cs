using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace BicycleSalon
{
    class ListOfBikes
    {
        private static int budgetOfSalon = 0;
        private static int numberOfBike = 1;

        List<Bike> bikes = new List<Bike>();

        //Add to list == Sell bike
        public void addToList(Bike bike)
        {
            bike.SellBike();
            bikes.Add(bike);
            budgetOfSalon -= bike.price;
        }

        //buy bike
        public void removeFromList(Bike bike) 
        {
            Console.Write("Give us number of the bike that would you like to buy: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice-1>=bikes.Count || choice-1<0)
            {
                Console.WriteLine("There is no bike with that number :( you're going to the menu...\n");
                return;
            }
            budgetOfSalon += bikes[choice - 1].price;
            bikes.RemoveAt(choice - 1);
            Console.WriteLine("You've bought the bike!\n");
        }

        public void showBikesFromList() 
        {
            Console.WriteLine("All salon's bikes:");
            if (bikes.Count == 0)
            {
                Console.WriteLine("Salon don't have any bike :(\n");
                return;
            }
            for (int i = 0; i<bikes.Count ;i++)
            {
                Console.WriteLine("Bike number " + numberOfBike++);
                bikes[i].showBike();
                Console.WriteLine("\n");
            }
            numberOfBike = 1;
        }
        
        public void replaceTheBike(Bike bike) 
        {
            Console.WriteLine("Give us the number of the bike from the list that you want to replace and some information about your bike: ");
            Console.Write("Number: ");      int choice = Convert.ToInt32(Console.ReadLine());
            if (choice - 1 >= bikes.Count || choice - 1 < 0)
            {
                Console.WriteLine("There is no bike with that number :( you're going to the menu...\n");
                return;
            }
            bikes.RemoveAt(choice - 1);
            budgetOfSalon += bike.price;
            bike.SellBike();
            bikes.Insert(choice - 1, bike);
        }

        public void showSalonBudget()
        {
            Console.WriteLine($"The budget of salon is: {budgetOfSalon} PLN");
            if(budgetOfSalon<0)
            {
                Console.WriteLine("Bicycle salon is in debt :(\n");
            }
            else if(budgetOfSalon==0)
            {
                Console.WriteLine("Bicycle salon is money-balanced\n");
            }
            else 
            {
                Console.WriteLine("Congratulation! Bicycle salon is richer :)\n");
            }
        }

        public void repairBike()
        {
            Console.WriteLine("What happend to your bike? We'll show you price-list of faults repair");
            Console.WriteLine("1. Replacement of the tube - 20 PLN\n" +
                              "2. Chain replacement - 45 PLN\n" +
                              "3. Bike review - 125 PLN\n" +
                              "4. Gear adjustment - 40 PLN\n" +
                              "5. Replacing the pedals - 20 PLN\n" +
                              "6. Brake replacement - 50 PLN\n" +
                              "7. Bike montage - 100 PLN\n" +
                              "8. Installation of lighting - 25 PLN\n" +
                              "9. Replacement of shock absorbers - 80 PLN\n" +
                              "10. Replacement of the steering wheel - 60 PLN\n");
            Console.Write($"Happening: "); int happening = Convert.ToInt32(Console.ReadLine());
            if(happening == 1) { budgetOfSalon += 20; }
            else if(happening == 2) { budgetOfSalon += 45; }
            else if(happening == 3) { budgetOfSalon += 125; }
            else if(happening == 4) { budgetOfSalon += 40; }
            else if(happening == 5) { budgetOfSalon += 20; }
            else if(happening == 6) { budgetOfSalon += 50; }
            else if(happening == 7) { budgetOfSalon += 100; }
            else if(happening == 8) { budgetOfSalon += 25; }
            else if(happening == 9) { budgetOfSalon += 80; }
            else if(happening == 10) { budgetOfSalon += 60; }
            else { Console.WriteLine("There is no no number. You are going to menu...\n"); return; }
            Console.WriteLine("You've repaird your bike!\n");
        }

        public void saveListToTheFile()
        {
            StreamWriter sw;
            Console.Write("How do you want to name file with available bikes?(add enlargement .txt !): ");
            string plik;
            bool nadpis;
            plik = Console.ReadLine();
            if (!File.Exists(plik))
            {
                sw = File.CreateText(plik);
                nadpis = false;
            }
            else
            {
                sw = new StreamWriter(plik, false);
                nadpis = true;
            }
                
            sw.WriteLine("All salon's bikes:");
            if (bikes.Count == 0)
            {
                sw.WriteLine("Salon don't have any bike :(");
            }
            for (int i = 0; i < bikes.Count; i++)
            {
                sw.WriteLine("Bike number: " + numberOfBike++);
                bikes[i].saveToFile(sw);
                sw.WriteLine("\n");
            }

            if (nadpis == false)
            {
                Console.WriteLine("The file was successfully created!\n");
            }
            else if(nadpis == true)
            {
                Console.WriteLine("File successfully overwritten!\n");
            }
            sw.Close();
            numberOfBike = 1;
        }

        public void showOneBrand()
        {
            Console.Write("Give us name of brand that u want to count all their bikes: ");
            string bikesBrand; bikesBrand = Console.ReadLine();
            var listWithOneBrand = bikes.Where(p => p.brand == bikesBrand);
            int counter = 0;
            if(listWithOneBrand.Count()==0)
            {
                Console.WriteLine("There is no bike from that brand :(\n");
                return;
            }
            for (int i = 0; i < listWithOneBrand.Count(); i++)
            {
                counter++;
            }
            Console.WriteLine($"There is {counter} bike/s from that brand!\n");
        }
    }
}
