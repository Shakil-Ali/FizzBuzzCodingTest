
namespace FizzBuzzCodingTest
{
    public class FizzBuzzMain
    {
        public string GetFizzBuzzOutput(int number)
        {

            // Logic to workout which string to return

            if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 5 == 0 && number % 3 == 0) 
            {
                return "FizzBuzz";
            }
            else
                return number.ToString();
        }
    }
}
