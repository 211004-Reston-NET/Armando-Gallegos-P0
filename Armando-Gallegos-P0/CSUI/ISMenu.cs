namespace CSUI
{
    public enum MenuChoices
    {
        MainMenu,
        ActivitiesMenu,
        RestaurantMenu,
        AdminMenu,
        ShowActivities,
        BookActivity,
        ShowRestaurants,
        BookRestaurant,
        AddPassanger,
        AddAttendant,
        AddActivity,
        Exit
    }
    //This will create the menus for our project
    public interface ISMenu
    {
        /// <summary>
        /// Will Display the main menu options
        /// </summary>
        void Menu();

        MenuChoices CustomerChoice();
    }

}