using System;
using System.Text.RegularExpressions;


namespace CSModels
{
    public class Activity
    {
        private string _activityName;
        private string _storeCity;
        private string _storeState;
        public string AName
        {
             get {return _activityName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _activityName = value;
             }
        }
        public string SState
        {
            
             get {return _storeState;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _storeState = value;
             }
        }
        public string SCity
        {
            
             get {return _storeCity;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Store Name can only be Alphabetic!");

                 }
                _storeCity = value;
             }
        }
        public override string ToString()
        {
            return $"Store Name: {AName}\nStore State: {SState}";
        }
    }
}