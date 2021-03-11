using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{
    //class = object all on it's own, class is a cookie cutter   
    public class Person
    {
        public string FullName 
        {
            get //we're getting this info, first name and last name. Then return as a full name
            {
                return $"{FirstName} {LastName}";
            }        
        }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {//double = another whole number
            get
            { //takes the date of birth and calculates
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;//using double because of 365.25 and datime.now
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge; 
            }
        }
        public Vehicle Transport { get; set; }//can use class properties with another class

        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        { //this is setting information that will be used later
            FirstName = firstName; //these are constructors, building object, person. putting cookiecutter down
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
     
    }
}
