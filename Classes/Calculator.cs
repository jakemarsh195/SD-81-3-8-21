using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator
    { //access modifier, int = return type, add = method signature, (parameters)
        public int Add(int numOne, int numTwo) //use void when we don't want anything returned,just want to display in the console
        { //result of method should be in return type
            int sum = numOne + numTwo;
            return sum;
        }
        public double add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo; //if do add, going to pull up either int or double
            return sum;
        }

        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears)); //converting total age in years as an int to int
            return years; //floor = rounds it down to whole number
        }
    }
}
