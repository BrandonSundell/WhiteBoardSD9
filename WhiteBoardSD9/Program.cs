using System;
using Alphabetize;
using CamelCaseAndPascalCase;
namespace WhiteBoardSD9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Sorts.StringSort("cat"));
            Console.WriteLine(CamelCase.ConvertToCamel("The Cat In The Hat"));
        }

    }
}
