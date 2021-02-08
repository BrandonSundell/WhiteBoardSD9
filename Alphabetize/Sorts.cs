using System;

namespace Alphabetize
{
    public static class Sorts
    {
        // write a method to return a string in alphabetical order
        public static string StringSort(string inputString)
        {
            // "cat" returns "act"
            string alphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string outputString = "";
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < inputString.Length; j++)
                {
                    if (alphabet[i] == inputString[j])
                    {
                        outputString += inputString[j];
                    }
                }
            }

            return outputString;
        }
    }
}
