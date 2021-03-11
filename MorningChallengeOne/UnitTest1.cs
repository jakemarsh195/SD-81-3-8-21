using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallengeOne
{
    [TestClass]
    public class Challenge1
    {
        string word = "supercalifragilisticexpialidocious";
        [TestMethod]
        public void stepOne()
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine(word.Length);
            foreach (char letter in word)
            {
                if (letter == 'i')
                {

                    Console.WriteLine(letter);
                }
                else if (letter == 's')
                {
                    Console.WriteLine('L');
                }
                else
                {
                    Console.WriteLine("not an I");
                }

            }    
        }
    }
}
