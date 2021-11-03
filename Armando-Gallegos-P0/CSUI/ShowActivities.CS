using System;
using System.Collections.Generic;
using CSModels;
using CSBL;

namespace CSUI
{
    public class ShowActivities : ISMenu
    {
        private IActivityBL _actBL;

        //Another dependency Injection
        public ShowActivities(IActivityBL p_actBL)
        {
            _actBL = p_actBL;
        }

        public MenuChoices UserChoice()
        {
            string ActivityChoice = Console.ReadLine();
            switch(ActivityChoice)
            {
                    case "0":
                        return MenuChoices.ActivitiesMenu1;
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
            List<Activity>listOfActivities = _actBL.GetAllActivities();
            foreach (Activity act in listOfActivities)
            {
                Console.WriteLine("================");
                Console.WriteLine(act);
                Console.WriteLine("=================");
            }
            Console.WriteLine("[0] - Go Back");
        }
    }
}