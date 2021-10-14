using System;
using CSModels;
using CSModel;
using EmployeeModel;
using CSBL;
using CSDL;

namespace StoreUI
{
    class SUI
    {
        static void Main(string[] args)
        {
            Passanger Cust = new Passanger();
            Employee Emp = new Employee();
            //I had Menu instead of MainMenu but it gave me a syntax error
            //MainMenu Men = new MainMenu(); 

            bool repeat = true;
            ISMenu page = new MainMenu();
            while(repeat)
            {
                Console.Clear();
                page.Menu();
                MenuChoices choice = page.CustomerChoice();
        
                switch (choice)
                {
                    case MenuChoices.MainMenu:
                        page = new MainMenu();
                        break;
                    case MenuChoices.ActivitiesMenu:
                        page = new ActivitiesMenu();
                        break;
                    case MenuChoices.ShowActivities:
                        page = new ShowActivities(new CruiseBL(new Repository()));
                        break;
                    case MenuChoices.Exit:
                        Console.WriteLine("You are exiting the application");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Coder you forgot yo write a menue option catch");
                        break;
                }
            }
        }
    }
}
