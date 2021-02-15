using System;

namespace BicycleSalon
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuObject = new menu();
            Bike bike = null;
            ListOfBikes listOfBikes = new ListOfBikes();
            while(true)
            {
                menuObject.showMenu();
                //choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choice: ");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("What kind of bike would you like to sell?\n1.BMX\n2.Road bike\n3.MTB\n4.City bike\n");
                        Console.Write("Choice: ");  int choiceBike = Convert.ToInt32(Console.ReadLine());
                        switch (choiceBike)
                        {
                            case 1:
                                bike = new BMX();
                                listOfBikes.addToList(bike);
                                break;
                            case 2:
                                bike = new RoadBike();
                                listOfBikes.addToList(bike);
                                break;
                            case 3:
                                bike = new MTB();
                                listOfBikes.addToList(bike);
                                break;
                            case 4:
                                bike = new CityBike();
                                listOfBikes.addToList(bike);
                                break;
                            default:
                                Console.WriteLine("Number out of range! Please try again\n");
                                break;
                        }
                        break;
                    case 2:
                        listOfBikes.removeFromList(bike);
                        break;
                    case 3:
                        Console.WriteLine("What kind of bike do you have?\n1.BMX\n2.Road bike\n3.MTB\n4.City bike\n");
                        Console.Write("Choice: "); int choiceYourBike = Convert.ToInt32(Console.ReadLine());
                        switch (choiceYourBike)
                        {
                            case 1:
                                bike = new BMX();
                                listOfBikes.replaceTheBike(bike);
                                break;
                            case 2:
                                bike = new RoadBike();
                                listOfBikes.replaceTheBike(bike);
                                break;
                            case 3:
                                bike = new MTB();
                                listOfBikes.replaceTheBike(bike);
                                break;
                            case 4:
                                bike = new CityBike();
                                listOfBikes.replaceTheBike(bike);
                                break;
                            default:
                                Console.WriteLine("Number out of range! Please try again\n");
                                break;
                        }
                        break;
                    case 4:
                        listOfBikes.repairBike();
                        break;
                    case 5:
                        listOfBikes.showBikesFromList();
                        break;
                    case 6:
                        listOfBikes.showSalonBudget();
                        break;
                    case 7:
                        listOfBikes.saveListToTheFile();
                        break;
                    case 8:
                        listOfBikes.showOneBrand();
                        break;
                    case 9:
                        Console.WriteLine("You are leaving the salon :(");
                        return;
                    default:
                        Console.WriteLine("Number out of range! Please try again\n");
                        break;                      
                }
            }
        }
    }
}
