namespace CSUI
{
    public enum MenuChoices
    {
        MainMenu,
        ListActivities,
        ActivitiesMenu1,
        ActivitiesMenu2,
        ActivitiesMenu3,
        RestaurantMenu,
        ShowActivities,
        BookActivity,
        ShowRestaurants,
        ShowPassengers,
        SearchPassbyName,
        SearchPassbyCabNo,
        PassActivitesMenu,
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