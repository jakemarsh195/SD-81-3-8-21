using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        
        public void SayHello(string name)
        {//when user writes their name, it will write Hello and their name
            Console.WriteLine($"Hello, {name}!"); 
        }
        public void SayHello() //esle, this will run just "Hello"
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[] { "Good Morning", "Whats up", "Whats up Dawg", "Howdy" };
            int randomNumber = _random.Next(0, availableGreetings.Length); //means stop at 4, stops at 3
            string randomGreeting = availableGreetings.ElementAt(randomNumber);//Element matches the number to the greeting
            Console.WriteLine($"{randomGreeting}");
        }
    }
}
