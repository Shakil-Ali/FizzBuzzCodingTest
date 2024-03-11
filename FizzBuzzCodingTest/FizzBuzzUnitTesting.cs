using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzChallenge.Tests
{
    public class FizzBuzzTests
    {
        public void GetFizzBuzz_Returns_Fizz_When_Divisible_By_Three()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Fizz", fizzBuzz.GetFizzBuzz(3));
        }

        public void GetFizzBuzz_Returns_Buzz_When_Divisible_By_Five()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", fizzBuzz.GetFizzBuzz(5));
        }

        public void GetFizzBuzz_Returns_FizzBuzz_When_Divisible_By_Both_Three_And_Five()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("FizzBuzz", fizzBuzz.GetFizzBuzz(15));
        }

        public void GetFizzBuzz_Returns_Number_When_Not_Divisible_By_Three_Or_Five()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.AreEqual("7", fizzBuzz.GetFizzBuzz(7));
        }
    }
}
