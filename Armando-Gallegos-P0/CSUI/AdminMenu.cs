using System;

namespace CSUI
{

    public class AdminMenu : ISMenu
    {
         public MenuChoices UserChoice()
        {
            string MainChoice = Console.ReadLine();
            switch(MainChoice)
            {
                case "1":
                    return MenuChoices.AddPassanger;
                case "2":
                    return MenuChoices.AddActivity;
                case "3":
                    return MenuChoices.AddRestaurant;
                case "4":
                    return MenuChoices.AddAttendant;
                case "0":
                    return MenuChoices.MainMenu;
                default:
                    Console.WriteLine("Please enter a valid response!");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    return MenuChoices.AdminMenu;
            }
        }

        public void Menu()
        {
            Console.WriteLine("This is the Administror's Access Menu");
            Console.WriteLine("Access restricted to Authorized Crew Members");
            Console.WriteLine("[4] - Add Attendants");
            Console.WriteLine("[3] - Add/Reserve Restaurant");
            Console.WriteLine("[2] - Add/Reserve Activies");
            Console.WriteLine("[1] - Add Passangers");
            Console.WriteLine("[0] - Return to the Main");
        }
    }
   
}