using System;
using CSBL;
using CSModels;

namespace CSUI
{
    public class AddActivity :ISMenu
    {
        private static Activity _act = new Activity();
        private IActivityBL _actBL;

        public AddActivity(IActivityBL p_actBL)
        {
            _actBL = p_actBL;
        }
        public void Menu()
        {
            bool correct = false;
            string answer;
            while(!correct)
            {
                Console.WriteLine("Adding a new Activity");
                Console.Write("Activity Name: ");
                _act.AName = Console.ReadLine();
                Console.Write("Activity Description: ");
                _act.ADescription = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You have entered:");
                Console.WriteLine("================");
                Console.WriteLine("Activity Name: " + _act.AName);
                Console.WriteLine("Activity Description: " + _act.ADescription);
                Console.WriteLine("=================");
                Console.WriteLine("Is this Correct?");
                Console.WriteLine("Enter [Y] for Yes or [N] to re enter the Activity Info.");
                answer = Console.ReadLine();
                if(answer == "Y")
                {
                    correct = true;
                    _actBL.AddActivity(_act);
                }
                else 
                    Console.Clear();
            }
        }
        
        public MenuChoices UserChoice()
        {
            return MenuChoices.AdminMenu;
        }
    }
}  