using System;

namespace pigLatin_capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptUser();
            string userInput;
            ConvertInputToPigLatin(userInput = Console.ReadLine().ToLower());
            ChooseAnotherWord();
        }

        // prompt user
        public static void PromptUser()
        {
            Console.WriteLine("Yo! Enter a word to translate into Pig Latin!\n");
        }

        //processing -- translate user's input into pig latin
        public static string ConvertInputToPigLatin(string wordToChange)
        {
            char[] vowels = {'a','e','i','o','u'};
            string pigWord = "";
            string[] array = wordToChange.Split(" ");
            foreach (string letter in array)
            {
                int currentLetter = letter.IndexOfAny(vowels);
               
                if (currentLetter == 0)
                {
                    pigWord = letter + "way ";
                    Console.Write(pigWord);
                }
                else
                {
                    string firstLetter = letter.Substring(0, currentLetter);
                    string otherLetters = letter.Substring(currentLetter); ;
                    pigWord = otherLetters + firstLetter + "ay ";
                    Console.Write(pigWord);
                }
            } 
            return pigWord;
        }

        public static void ChooseAnotherWord()
        {
            bool go = true;
            while (go)
            {
                Console.WriteLine("\n\nEnter another word [y/n]?");
                string userOption = Console.ReadLine().ToLower();
                if (userOption == "y" || userOption == "yes")
                {
                    Console.WriteLine("\nEnter a word to translate into Pig Latin!");
                    ConvertInputToPigLatin(userOption = Console.ReadLine().ToLower());
                }
                else if (userOption == "n" || userOption == "no")
                {
                    Console.WriteLine("\nPig Latin.OUT.");
                    go = false;
                }
                else
                {
                    Console.WriteLine("\nPlease choose either \"yes\" or \"no.\" ");
                }
            }
        }
    }
        
}
