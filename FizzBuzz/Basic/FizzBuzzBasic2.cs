using System;

namespace FizBuzz
{
    public class FizzBuzzBasic2
    {
        public void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(PrintFizzBuzz(i));
            }
        }

        public string PrintFizzBuzz(int number)
        {
            if (IsFizz(number) && IsBuzz(number))
            {
                return "FizBuzz";
            }
            else if (IsFizz(number))
            {
                return "Fiz";
            }
            else if (IsBuzz(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public bool IsFizz(int number)
        {
            return (number % 3 == 0);
        }

        public bool IsBuzz(int number)
        {
            return (number % 5 == 0);
        }
    }
}
