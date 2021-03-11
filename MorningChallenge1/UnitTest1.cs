using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenge1
{
    [TestClass]
    public class MorningChallengeone()
    {
        [TestMethod]
        public void TestMethod1()
        {
            string challenge = "supercalifragilisticexpialidocious";

            foreach (char letter in challenge)
            {
                if(letter != ' ')
                {

                    Console.WriteLine(letter);
                
                }
                
            }
            
        }
    }
}
