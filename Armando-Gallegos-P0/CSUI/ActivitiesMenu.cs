using System;

namespace CSUI
{
     public class ActivitiesMenu : ISMenu
    {
        private string _shipsName;

        public ActivitiesMenu(string p_shipsName)
        {
            _shipsName = p_shipsName;
        }
        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "4":
                        return MenuChoices.ShowActivities;
                    case "3":
                        return MenuChoices.ShowRestaurants;
                    case "2":
                        return MenuChoices.BookActivity;
                    case "1":
                        return MenuChoices.BookRestaurant;
                    case "0":
                        return MenuChoices.MainMenu;
                    default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.MainMenu;
            }
        }
        public void Menu()
            {
                Console.WriteLine("Welcome to the " + _shipsName + " Activities Menu");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[4] - List all Ship Board Activities");
                Console.WriteLine("[3] - List all of the Restaurants on ship");
                Console.WriteLine("[2] - Make a booking for an activity");
                Console.WriteLine("[1] - Book a table at your Restaurant");
                Console.WriteLine("[0] - Return to the Main Menu");
            }
    }  
}