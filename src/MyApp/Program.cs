using System;
using System.Collections.Generic;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a quantidade de números que deseja?");
            int numberUser = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            NumbersList listNumbersUser = new NumbersList();

            listNumbersUser.UserNumbers(numberUser);
        }
    }
}