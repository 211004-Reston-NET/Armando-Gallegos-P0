using System;
using System.Collections.Generic;
using CSDL;
using CSModels;

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
        public List<Activity> GetAllStores()
        {
            return  _repo.GetAllStores();
        }
    }
}
