using System.Collections.Generic;
using CSModels;

namespace CSDL
{
/// <summary>
/// We are adding to our JSON repositories
/// </summary>
    public interface IRepository
    {
        Activity AddActivity(Activity p_act);

        Restaurant AddRestaurant(Restaurant p_rest);

/// <summary>
/// This is a replication of the get funtions in our repository class
/// </summary>
/// <returns></returns>
        List<Activity> GetAllActivities();

        List<Restaurant> GetAllRestaurants();
    }
}