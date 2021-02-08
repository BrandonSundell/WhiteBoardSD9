using System;

namespace CamelCaseAndPascalCase
{
    public static class CamelCase
    {
        //write a method that converts a string into Camel Case 
        //"Cat In The Hat" should return "catInTheHat"
        public static string ConvertToCamel(string inputString)
        {
            string outputString = "";
            bool foundFirst = false;
            for (int i = 0; i < inputString.Length; i++)
            { 
                if (inputString[i] != ' ')
                {
                    //cleaner way to say (foundFirst == false)
                    if (!foundFirst)
                    {
                        //if the first char we find IS NOT a space then convert that char to lower case and add,
                        //that char to the outputString then set foundFirst to true
                        outputString += inputString[i].ToString().ToLower();
                        foundFirst = true;
                    }
                    else if (i != 0 && inputString[i-1] == ' ')
                    {
                        //if the index of the inputString IS NOT 0 and the char behind the current char we are,
                        //checking is a space then convert the current char to upper case and add it to the outputString
                        outputString += inputString[i].ToString().ToUpper();
                    }
                    else
                    {
                        //otherwise convert all other chars to lower case and add them to the outputString
                        outputString += inputString[i].ToString().ToLower();
                    }
                    
                } 
            }
            return outputString;
        }

        public static string ConvertToPascal(string inputString)
        {
            string outputString = "";


            return outputString;
        }
    }
}
