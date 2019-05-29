using System;
using System.Collections.Generic;

namespace list_of_dictionaries_about_words
{
    class Program
    {
        static void Main(string[] args)
        {

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // /*
            //     You want to track the following about each word:
            //         word, definition, part of speech, example sentence

            //     Example of one dictionary in the list:
            //     {
            //         "word": "excited",
            //         "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
            //         "part of speech": "adjective",
            //         "example sentence": "I am excited to learn C#!"
            //     }
            // */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("partOfSpeech", "adjective");
            excitedWord.Add("exampleOfUse", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> successWord = new Dictionary<string, string>();

            //Add each of the 4 bits of data about the word to the Dictionary
            successWord.Add("word", "success");
            successWord.Add("definition", "the accomplishment of an aim or purpose.");
            successWord.Add("partOfSpeech", "noun");
            successWord.Add("exampleOfUse", "the president had some success in restoring confidence.");

            //Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(successWord);

            //Create another Dictionary and add that to the list.
            Dictionary<string, string> funWord = new Dictionary<string, string>();

            //add each of the 4 bits of data about the word to the Dictionary.
            funWord.Add("word", "fun");
            funWord.Add("definition", "enjoyment, amusement, or lighthearted pleasure.");
            funWord.Add("partOfSpeech", "noun");
            funWord.Add("exampleOfUse", "the children were having fun in the play area.");

            dictionaryOfWords.Add(funWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach (int num in numbers) {
                Console.WriteLine($"{num}");
            }


            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> dictionary in dictionaryOfWords)
            {
                Console.WriteLine("---------------------------------");
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in dictionary)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
