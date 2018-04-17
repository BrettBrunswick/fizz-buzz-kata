using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string print(int v)
        {

            if (IsDivisibleBy3And5(v))
            {
                return "FizzBuzz";
            }

            if (IsDivisibleBy3(v))
            {
                return "Fizz";
            }

            if (IsDivisibleBy5(v))
            {
                return "Buzz";
            }

            return v.ToString();
        }

        private static bool IsDivisibleBy3(int v)
        {
            return (v % 3 == 0);
        }

        private static bool IsDivisibleBy5(int v)
        {
            return (v % 5 == 0);
        }

        private static bool IsDivisibleBy3And5(int v)
        {
            return ((v % 3 == 0) && (v % 5 == 0));
        }
    }

}