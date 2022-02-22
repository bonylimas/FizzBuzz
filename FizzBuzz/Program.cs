using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string toDisplay = "";

                toDisplay = i % 3 == 0 ? toDisplay + "Fizz" : toDisplay;
                toDisplay = i % 5 == 0 ? toDisplay + "Buzz" : toDisplay;
                toDisplay = toDisplay.Length <= 0 ? i.ToString() : toDisplay;

                Console.WriteLine(toDisplay);
            }
        }
    }
}

