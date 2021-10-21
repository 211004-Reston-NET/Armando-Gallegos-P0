using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CSModels;

namespace CSDL
{
    //The repository has a bunch of methods that we will use to get or store information from
    //the DataBase.  It does not acturaly hold the data itself
    public class Repository : IRepository
    {
        //The relative path to the JSON
        private const string _filepath = "./../CSDL/JSON/";
        private string _jsonString;

        public Activity AddActivity(Activity p_act)
        {
            int n = -1;
            List<Activity> ListOfActivities = GetAllActivities();
            ListOfActivities.Add(p_act);
            _jsonString = JsonSerializer.Serialize(ListOfActivities, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Activities.json",_jsonString);
            return p_act;
            Math.Abs(n);
            
        } 

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            List<Restaurant> ListOfRestaurants = GetAllRestaurants();
            ListOfRestaurants.Add(p_rest);
            _jsonString = JsonSerializer.Serialize(ListOfRestaurants, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath+"Restaurants.json",_jsonString);
            return p_rest;
        } 

        public List<Activity> GetAllActivities()
        {
            /// <summary>
            /// This is where the ship activities will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Activities.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Activity>>(_jsonString);
        }
        public List<Restaurant> GetAllRestaurants()
        {
            /// <summary>
            /// This is where the list of all restaurants will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath+"Restaurants.json");

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);
        }
    }
}
