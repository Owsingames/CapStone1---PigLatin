using System;

namespace Capstone1___Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to PigLatin translator");

            bool onContinue = true;
            while (onContinue == true)
            {
                string message = GetUserInput("");
                string translation = ToPigLatin(message);
                Console.WriteLine(translation);
                onContinue = PickAgain();
            }
        }

        public static string GetUserInput(string input)
        {
            Console.WriteLine("Enter a word or phrase and I will translate it to Pig Latin \n");
            string phrase = Console.ReadLine().ToLower();
            return phrase;
        }

        public static bool PickAgain()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to translate more words or phrases?");
            Console.WriteLine("Enter: yes or no");

            string userAnswer = Console.ReadLine().ToLower();

            if(userAnswer == "yes" || userAnswer == "y")
            {
                Console.Clear();
                return true;
            }
            else if(userAnswer == "no" || userAnswer == "n")
            {
                Console.WriteLine("Goodbye");
                return false;
            }
            else
            {
                Console.WriteLine("I did not understand...");
                return PickAgain();
            }
        }

        public static string ToPigLatin(string input)
        {
            //array of words input from user
            string[] words = input.Split(' ');
            string translation = "";
            string newWord;


            //move through the array of words
            foreach (string word in words)
            {
                //if word starts with vowel
                if (HasVowel(word) == true)
                {
                    newWord = word + "way ";
                    translation += newWord;
                }
                else
                {
                    //move the first letter of the word to the back and add "ay"
                    string output = word.Substring(1, word.Length - 1) + word.Substring(0, 1) + "ay ";
                    translation += output;
                }
            }
            return translation;
        }

        //Check word for vowel
        public static bool HasVowel(string word)
        {
            //vowels array
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if (word.Contains(vowel) && word.IndexOf(vowel) == 0)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
