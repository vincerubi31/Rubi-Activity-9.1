using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> translator =
            new Dictionary<string, string>();

        translator.Add("Hello", "Kablaaw");
        translator.Add("Good morning", "Naimbag nga bigat");
        translator.Add("Good afternoon", "Naimbag nga mallem");
        translator.Add("Good evening", "Naimbag nga rabii");
        translator.Add("Thank you", "Agyamanak");
        translator.Add("Yes", "Wen");
        translator.Add("No", "Awan");
        translator.Add("Water", "Danum");
        translator.Add("Food", "Makan");
        translator.Add("Friend", "Gayyem");

        string choice = "Y";

        while (choice.ToUpper() == "Y")
        {
            Console.WriteLine("\nAVAILABLE WORDS:");

            foreach (KeyValuePair<string, string> item in translator)
            {
                Console.WriteLine("- " + item.Key);
            }

            Console.Write("\nEnter the English word to translate: ");
            string word = Console.ReadLine();

            if (translator.ContainsKey(word))
            {
                Console.WriteLine("Translation: " + translator[word]);
            }
            else
            {
                Console.WriteLine("Word not found in the dictionary.");
            }

            Console.Write("\nDo you want to translate another word? (Y/N): ");
            choice = Console.ReadLine();
        }

        Console.WriteLine("\nProgram Ended.");
    }
}