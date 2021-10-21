using System;
using CSModels;
using CSModel;
using EmployeeModel;
using CSBL;
using CSDL;

namespace CSUI
{
    class SUI
    {
        static void Main(string[] args)
        {
            Passanger Cust = new Passanger();
            Attendant Emp = new Attendant();
            //I had Menu instead of MainMenu but it gave me a syntax error
            //MainMenu Men = new MainMenu(); 

            bool repeat = true;
            ISMenu page = new MainMenu();
            while(repeat)
            {
                Console.Clear();
                page.Menu();
                MenuChoices choice = page.UserChoice();
        
                switch (choice)
                {
                    case MenuChoices.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuChoices.ActivitiesMenu:
                        page = new ActivitiesMenu();
                        break;
                    case MenuChoices.AddActivity:
                        page = new AddActivity(new ActivityBL(new Repository()));
                        break;
                    case MenuChoices.AddRestaurant:
                        page = new AddRestaurant(new RestaurantBL(new Repository()));
                        break;
                    case MenuChoices.ShowActivities:
                        page = new ShowActivities(new ActivityBL(new Repository()));
                        break;
                    case MenuChoices.RestaurantMenu:
                        page = new RestaurantMenu();
                        break;
                    case MenuChoices.ShowRestaurants:
                        page = new ShowRestaurants(new RestaurantBL(new Repository()));
                        break;
                    case MenuChoices.AdminMenu:
                        page = new AdminMenu();
                        break;
                    case MenuChoices.Exit:
                        Console.WriteLine("You are exiting the application");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Coder you forgot yo write a menu option catch");
                        break;
                }
            }
        }
    }
}
