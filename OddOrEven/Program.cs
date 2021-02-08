using System;

namespace OddOrEven
{
    class Program
    {
        static bool IsOdd(int inputValue) => inputValue % 2 != 0;

        static bool IsEven(int inputValue) => inputValue % 2 == 0;
        static void Main(string[] args)
        {
            Console.WriteLine("OddOrEven");

            for (int i = 0; i < 10; i++)
            {
                string result = "";
                if (IsEven(i)) result = "even";
                if (IsOdd(i)) result = "odd";
                Console.WriteLine($"{i}: {result}");
            }
        }
    }
}
