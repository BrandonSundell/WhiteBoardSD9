using System;
using Alphabetize;
using CamelCaseAndPascalCase;
using PrimeNumbers;
namespace WhiteBoardSD9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Sorts.StringSort("cat"));
            Console.WriteLine(CamelCase.ConvertToCamel("The Cat! In The Hat"));
            Console.WriteLine(Prime.IsPrime(10));
            Console.WriteLine(Prime.IsPrime(11));
            Console.WriteLine(Prime.IsPrime(14));
            Console.WriteLine(Prime.IsPrime(17));
            Console.WriteLine(Prime.SumOfPrimes(10));
        }

    }
}
