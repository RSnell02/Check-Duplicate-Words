/*
 * Program: Snell-Spr2020-21.9-DuplicateWords
 * Filename: CheckDuplicateWords.cs
 * Author: R. Snell
 * Date: Dec. 01, 2020
 * Purpose: To catch and count duplicate words in a sentence. Uppercase and lowercase letters are
 *          treated the same and punctuation marks are ignored. A counter will display each times
 *          a word has been used.
 */
using System;
using System.Collections.Generic;
using System.Collections;


namespace Snell_Spr2020_21._9_DuplicateWords
{
    class CheckDuplicateWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duplicate Word Check\n--------------------");

            //Prompt the user and input the statement
            Console.WriteLine("Enter the statement:");
            string s = Console.ReadLine();

            //Array to define characters for splitting the statement
            char[] splitter = new char[] { ',', '.', ' ' };

            //Create a generic collection of words
            ArrayList I = new
                ArrayList(s.Split(splitter));

            ArrayList Id = new ArrayList();   //Create a new list to put distinct words

            string ss1; //Declare a string to check duplicates

            //Run a loop to check all of the strings in the list
            foreach (string ss in I)
            {
                ss1 = ss.ToLower(); //Convert the word to the lowercase to ignore the case

                //Check if this is in the collection of distinct words.
                //Continue the loop if the word already exists
                if (Id.Contains(ss1) && ss1.Trim() != "")
                    continue;
                else
                    Id.Add(ss1);
            }   //End foreach

            // Create an enumerator for the collection
            IEnumerator ie = I.GetEnumerator();
            int chkCount;
            Console.WriteLine("\nWord\tFrequency");
            
            //Run a check on all strings in the list object and check each distinct word
            foreach (string testStr in Id)
            {
                if (testStr.Trim() != "")
                {
                    chkCount = 0;
                    ie.Reset(); //Set the enumerator at the start of the list
                    while (ie.MoveNext())
                    {
                        if (String.Compare((string)ie.Current, testStr, true) == 0)
                            ++chkCount;
                    }   //End while

                    //Display the word and frequency if it has repeated
                    if (chkCount > 1)
                        Console.WriteLine("{0}\t{1}", testStr, chkCount);
                } //End if
            }   //End foreach

            Console.ReadKey();
        }   //End class
    }   //End Main()
}   //End namespace
