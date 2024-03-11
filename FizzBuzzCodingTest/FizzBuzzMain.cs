using System;

namespace FizzBuzzChallenge
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int number)
        {
            // Logic for finding which term to output

            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }


        public void PrintFizzBuzzRange(int start, int end)
        {
            for(int i = start; i < end; i++) 
            {
                Console.WriteLine(GetFizzBuzz(i));
            }
        }

    }
}
