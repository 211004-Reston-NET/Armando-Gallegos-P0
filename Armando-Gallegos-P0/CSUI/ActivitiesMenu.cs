using System;

namespace CSUI
{
     public class ActivitiesMenu : ISMenu
    {
        public MenuChoices CustomerChoice()
        {
            string StoreChoice = Console.ReadLine();
            switch(StoreChoice)
            {
                    case "2":
                        return MenuChoices.ShowActivities;
                    case "1":
                        Console.WriteLine("Book an Activity");
                        Console.ReadLine();
                        return MenuChoices.BookActivity;
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
                Console.WriteLine("Welcome to the Ships Activities Menu");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[2] - List all Ship Board Activities");
                Console.WriteLine("[1] - Make a booking for an activity");
                Console.WriteLine("[0] - Return to the Main Menu");
            }
    }  
}