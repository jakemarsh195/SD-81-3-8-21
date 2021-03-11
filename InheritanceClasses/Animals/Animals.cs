using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses
{                           //1            //2          //3  //enum = group of constants, genres. we can categorize
    public enum DietType { Herbivore = 1, Omnivore, Carnivore}

    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("This is Animal Constructor.");
        }           //This is what makes our animal=important
        public string AnimalName { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }                
        public DietType DietType { get; set; }

        public virtual void Move() //vitual allows writeline to be overwritten by any future class made
        {
            Console.WriteLine($"This {GetType().Name} moves");
        }

    }
}
