using System;

namespace PrimeNumbers
{
    public class Prime
    {
        public static bool IsPrime(int inputNumber)
        {
            for (int i = 2; i < inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int SumOfPrimes(int inputNumber)
        {
            int sumOfPrimes = 0;
            for (int i = 2; i <= inputNumber; i++)
            {
                //if i IsPrime = true add the value that is on the left side the colon if false add the value on the right 
                sumOfPrimes += IsPrime(i) ? i : 0;
            }
            return sumOfPrimes;
        }
    }
}
