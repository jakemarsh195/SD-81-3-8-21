using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTests
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1; //Just for setup...

            //Please keep running as long as total isn't 10
            while (total !=10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;

            while (true)
            {
                if (total ==10)
                {
                    Console.WriteLine("Goal Reached");
                    break; //will allow to jump out of while loop
                }

                total++;
            }
            //new setup
            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {                           //0 inclusive, 20exclusive so, its 19 (0-19)
                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue; 
                }

                Console.WriteLine(someCount);

                if(someCount == 15) //total++ is the same as total = total
                {
                    keepLooping = false;
                }
            }

            
        }
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;
            //for tab tab. Initialization Conditional Increment
            for (int i = 1; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };
                                        //array
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }
            //string is an array f char
            string MyName = "JacobMarsh";

            foreach (char letter in MyName)
            {
                
                {
                    Console.WriteLine(letter);

                }
            }

            
        }

        [TestMethod]
        public void DoWhileLoops()
        {  
            int iterator = 0;
            do //I always run at aleast once!!!
            {
                Console.WriteLine("Hello");
                iterator++;
            } while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is False!!!");
            } while (false);

            while (false)
            {   //linter is telling us the code is unreachable (in background of VS)
                Console.WriteLine("My while condition is false");
            }
        }
    }
}
