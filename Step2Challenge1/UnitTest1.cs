using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Step2Challenge1
{
    [TestClass]
    public class UnitTest1
    {
        string challenge = "supercalifraglistickexpealidocious";
        [TestMethod]
        public void Step2()
        {
            foreach (char letter in challenge)
            {
                if (letter != 'i')
                    if (letter != '1')
                {

                    Console.WriteLine("not an i");
                }
                    if (letter == '1')
                {
                    Console.WriteLine('i');
                }
                else
                {
                    Console.WriteLine('Not an I');
                }
            }
        }
        [TestMethod]
        public void CountingLetter()
        {
            Console.WriteLine(word.Length);
        }
        
        

        }
    }
}
