using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmployeeModel
{
    public class Attendant
    {
        private  string _attName;
        public string EmployeeName 
        { 
            get
            {
                return _attName;
            } 
            
            set
            {
                _attName = value;
            } 
        }
        private List<int> Sales = new List<int>();
        public float sales { get; set; }
        
    }
}