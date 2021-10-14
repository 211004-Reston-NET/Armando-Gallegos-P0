using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace StoreUI
{
    public class ShowActivities : ISMenu
    {
        private CruiseBL _storeBL;

        //Another dependency Injection
        public ShowActivities(CruiseBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public MenuChoices CustomerChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "0":
                        return MenuChoices.ActivitiesMenu;
                    default:
                        Console.WriteLine("Please enter a valid response!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        return MenuChoices.ShowActivities;
            }
        }

        public void Menu()
        {
            Console.WriteLine("List of Activities");
            List<Activity>listOfStores = _storeBL.GetAllStores();
            foreach (Activity stor in listOfStores)
            {
                Console.WriteLine("================");
                Console.WriteLine(stor);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[0] - Go Back");
        }
    }
}