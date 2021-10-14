namespace StoreUI
{
    public enum MenuChoices
    {
        MainMenu,
        ActivitiesMenu,
        RestaurantMenu,
        ShowActivities,
        BookActivity,
        ShowRestaurants,
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