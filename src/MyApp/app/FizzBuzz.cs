using System;
using System.Collections.Generic;

namespace myapp
{
    public class FizzBuzz
    {
        public List<string> Execute(List<int> amount)
        {
            List<string> list = new List<string>();

            foreach (var number in amount)
            {
                string result = "";

                if (number % 3 == 0)
                {
                    result = "Fizz";
                }

                if (number % 5 == 0)
                {
                    result += "Buzz";
                }

                if (result == "")
                {
                    result = number.ToString();
                }

                list.Add(result);
            }

            return list;


            // for (int i = 1; i <= numbers; i++)
            // {
            //     string list = "";

            //     if (i % 3 == 0)
            //     {
            //         list = "Fizz";
            //     }

            //     if (i % 5 == 0)
            //     {
            //         list += "Buzz";
            //     }

            //     if (list == "")
            //     {
            //         list = i.ToString();
            //     }

            //     Console.WriteLine(list);
            // }
        }
    }
}
