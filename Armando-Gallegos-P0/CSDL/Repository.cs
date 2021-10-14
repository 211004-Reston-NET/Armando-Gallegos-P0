using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CSModels;

namespace CSDL
{
    //The repository has a bunch of methods that we will use to get or store information from
    //the DataBase.  It does not acturaly hold the data itself
    public class Repository
    {
        //The relative path to the JSON
        private const string _filepath = "./../CSDL/JSON/Activities.json";
        private string _jsonString;

/*public Store AddStores(Store p_store)
        {
            List<Store> ListOfStores = GetAllStores();
            ListOfStores.Add(p_store);
            _jsonString = JsonSerializer.Serialize(ListOfStores, new JsonSerializerOptions{WriteIndented=true});
            File.WriteAllText(_filepath,_jsonString);
            return p_store;
        } */

        public List<Activity> GetAllStores()
        {
            /// <summary>
            /// This is where the Json content will be stored
            /// </summary>
            /// <returns></returns>
            _jsonString = File.ReadAllText(_filepath);

            //Converting from string(JSON) into an object
            return JsonSerializer.Deserialize<List<Activity>>(_jsonString);
        }
    }
}
