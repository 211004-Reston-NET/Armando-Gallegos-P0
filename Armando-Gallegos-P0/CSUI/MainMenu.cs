using System;

namespace StoreUI
{

    public class MainMenu : ISMenu
    {
        public MenuChoices CustomerChoice()
        {
            string MainChoice = Console.ReadLine();
            switch(MainChoice)
            {
                case "1":
                    return MenuChoices.RestaurantMenu;
                case "2":
                    return MenuChoices.ActivitiesMenu;
                case "0":
                    return MenuChoices.Exit;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.MainMenu;
            }
        }
        public void Menu()
        {
            Console.WriteLine("Welcome to the StarLine Cruise Ship");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("[2] - Go to the Cruise Activities Menu");
            Console.WriteLine("[1] - Book a Restaurant");
            Console.WriteLine("[0] - Exit");
            Console.WriteLine("[X] - Admin Menu");
        }
    }
   
}