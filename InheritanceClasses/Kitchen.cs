using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{

    public class Kitchen : House   //here we are inheriting from the House class.
    {//house is the main class, Kitchen is subclass but not, taking properties from House
        public Kitchen()
        {
            SquareFeet = 500; //from House
            Flooring = FloorType.Wood;
        }
        public int NumberOfAppliances { get; set; }
        public bool HasAnIsland { get; set; }
        public string GoodPartySpace { get; set; }


    }
}
