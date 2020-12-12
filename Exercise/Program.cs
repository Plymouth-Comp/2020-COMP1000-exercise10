using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise
{

    public class Program
    {

        /// <summary>
        ///Split the given text using the given character and
        ///shuffle the strings so that the elements are concatinated in reverse order
        ///using the separator to connect them.
        ///
        /// Now also make sure to keep the dot at the end of the sentence and that the
        /// all words in the sentence are lower case except for the sentence start
        /// example: "Hello my friend.", ' ' turns into "Friend my hello."
        /// </summary>
        /// <param name="text1">a sample sentence to read</param>
        /// <param name="separator">the separator used between the words</param>
        /// <returns></returns>
        public string ShuffelTheText(string text1, char separator)
        {
            return string.Empty;
        }

        /// <summary>
        /// Adds a subset of integer numbers. Each number used must be smaller than boundary
        /// using LINQ or Lists will result in failing the entire exercise
        /// </summary>
        /// <param name="array">the input dataset</param>
        /// <param name="boundary">the threshold which defines the value above the maximum number that should considered for addition</param>
        /// <returns>the sum of all numbers that are below the threshold</returns>
        public int AddValuesBelowBoundary(int[] array, int boundary)
        {
            return -10000;
        }

        /// <summary>
        /// Retrieve Substring between start and finish.
        /// Split the given string and create a new string that combines all split elements including the split character
        /// from the start and before the finish index ( cuts in the text) .
        /// </summary>
        /// <param name="original">The input text which contains a number of potential split characters</param>
        /// <param name="split">the character used to cut the original</param>
        /// <param name="start">the first part to take and add it to the return value</param>
        /// /// <param name="finish">the index beyond the values to take into account</param>
        /// <returns></returns>
        public string ReturnSpecificSubText(string original, char split, int start, int finish)
        {
            return "";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercise 10!");
        }
    }
}
