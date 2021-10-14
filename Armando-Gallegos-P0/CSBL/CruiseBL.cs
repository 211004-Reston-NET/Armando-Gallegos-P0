using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{
    public class CruiseBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private Repository _repo;
        //GETTER
        public CruiseBL(Repository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Activity> GetAllActivities()
        {
            return  _repo.GetAllActivities();
        }

        public List<Activity> GetAllRestaurants()
        {
            return  _repo.GetAllRestaurants();
        }
    }
}
