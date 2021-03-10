using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry) 
            {
                Console.WriteLine("Eat Something!");
            }

            int hoursSpentStudying = 1;
            if(hoursSpentStudying < 16) 
            {
                Console.WriteLine("Are you even trying");
            }
        }
        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone) //if and bool name should be exact same
            {
                Console.WriteLine("Have fun at the movies!");
            }//else = if it's not true what are we doing
            else
            {
                Console.WriteLine("You must stay home and finish your CHORES!!");
            }


            string input = "2";
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("You should be well rested!!");
            }
            else
            {
                Console.WriteLine("You might be tired today.");
                if (totalHours < 4)
                {
                    Console.WriteLine("You should get more SLEEP!!!");
                }
            }

            int age = 36;
            if (age > 17)
            {
                Console.WriteLine("You are an Adult!!");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("You are a kid");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are far to young to be on a computer");
                }
                else
                {
                    Console.WriteLine("You are not born yet");
                }//if and else statements don't need C braces, but best practice
            }

            if(age < 65 && age > 18) //&& = and
            {
                Console.WriteLine("Age is between 18 and 65");
            }

            if(age > 65  || age < 18) //|| = or  //17 below or 66 above
            {
                Console.WriteLine("Age is either Greater than 65 or less than 18");
            }
            
            if(age == 21) //== means equal
            {
                Console.WriteLine("Age is equal to 21");
            }
            if(age != 36) //!= means not equal
            {
                Console.WriteLine("Age is not equal to 36!!");
            }
        }
    }
}
