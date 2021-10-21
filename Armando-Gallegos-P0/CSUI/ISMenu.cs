namespace CSUI
{
    public enum MenuChoices
    {
        MainMenu,
        ListActivities,
        ActivitiesMenu,
        RestaurantMenu,
        ShowActivities,
        BookActivity,
        ShowRestaurants,
        BookRestaurant,
        AdminMenu,
        AddPassanger,
        AddAttendant,
        AddRestaurant,
        AddActivity,
        Exit
    }

  /*  public enum AdminMenuChoices
    {
        AdminMenu,
        AddPassanger,
        AddAttendant,
        AddRestaurant,
        AddActivity,
        Exit 
    }*/

    //This will create the menus for our project
    public interface ISMenu
    {
        /// <summary>
        /// Will Display the main menu options
        /// </summary>
        void Menu();

        MenuChoices UserChoice();
      //  AdminMenuChoices AdminChoices();

    }

}