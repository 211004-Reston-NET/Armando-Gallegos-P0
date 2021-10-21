using System;
using System.Collections.Generic;
using CSModels;
using CSDL;

namespace CSBL
{
    public class ActivityBL : IActivityBL
    {
        /// <summary>
        /// this is the dependency injection
        /// </summary>
        /// <returns></returns>
        private IRepository _repo;
        //GETTER
        public ActivityBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        //SETTER
        public List<Activity> GetAllActivities()
        {
            //This will capitalize all of the Names in the activities JSON
            List<Activity> listOfActivities = _repo.GetAllActivities();
            for (int i = 0; i < listOfActivities.Count; i++)
            {
                listOfActivities[i].AName = listOfActivities[i].AName.ToUpper();
            }
            return  listOfActivities;
        }

        public Activity AddActivity(Activity p_act)
        {
            return _repo.AddActivity(p_act);
        }
    }
}
