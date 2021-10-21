using System;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class Activity
    {
        private string _activityName;
        private string _activityDescription;

        public string AName
        {
             get {return _activityName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _activityName = value;
             }
        }
        public string ADescription
        {
            
             get {return _activityDescription;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .,']+$"))
                 {

                     throw new Exception("Activity description can only be Alphabetic!");

                 }
                _activityDescription = value;
             }
        }
    /*    public string SCity
        {
            
             get {return _storeCity;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Store Name can only be Alphabetic!");

                 }
                _storeCity = value;
             }
        } */
        public override string ToString()
        {
            return $"Activity Description: {AName}\nActivity Description: {ADescription}";
        }
    }
}