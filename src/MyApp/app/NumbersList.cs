using System;
using System.Collections.Generic;

namespace myapp
{
    public class NumbersList
    {
        public void UserNumbers(int numbersUser)
        {
            List<int> amountNumbers = new List<int>();
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (var i = 1; i <= numbersUser; i++)
            {
                amountNumbers.Add(i);
            }

            fizzBuzz.Execute(amountNumbers).ForEach(Console.WriteLine);
        }
    }
}
