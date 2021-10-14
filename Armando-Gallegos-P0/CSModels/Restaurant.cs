using System;
using System.Text.RegularExpressions;

namespace CSModels
{
    public class Restaurant
    {
        private string _restName;
        private string _restDescription;
        public string RName
        {
             get {return _restName;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _restName = value;
             }
        }
        public string RDescription
        {
            
             get {return _restDescription;}
             set {
                 if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                 {

                     throw new Exception("Activity Name can only be Alphabetic!");

                 }
                _restDescription = value;
             }
        }
      /*  public string SCity
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
        }*/
    }
}