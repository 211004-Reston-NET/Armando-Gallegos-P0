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
       //         case "1":
       //             return MenuChoices.ShowActivities;
                case "1":
                    return MenuChoices.ShowPassengers;
                case "2":
                    return MenuChoices.AddPassanger;
                case "3":
                    return MenuChoices.AddActivity;
             //   case "5":
             //       return MenuChoices.AddRestaurant;
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
       //     Console.WriteLine("[5] - Add/Reserve Restaurant");
            Console.WriteLine("[3] - Add Activies");
            Console.WriteLine("[2] - Add Passangers");
            Console.WriteLine("[1] - Show Ships Passengers");
        //    Console.WriteLine("[1] - Show Ships Activities");
            Console.WriteLine("[0] - Return to the Main");
        }
    }
   
}