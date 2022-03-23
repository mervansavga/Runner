using System;
using System.Linq;
using System.Text;

namespace SequenceAnalysis
{
    public class StringSequenceAnalysis
    {

        /// <summary>
        ///Sorts the capital lettered words in a sentence
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string AnalyzeStringSequence(string inputString)
        {
            // An alternative solution could be to use method chaining by implementing our
            // own alternative for a string class depending on the purpose of the library

            // We could also use strategy pattern to extend this implementation

            if (String.IsNullOrEmpty(inputString))
            {
                return String.Empty;
            }

            string result = String.Empty;
            
            result = FindUppercaseWordsInString(inputString);
                
            result = SortStringAlphabetically(result);
                
            return result;


        }
        private static string FindUppercaseWordsInString(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            string currentWord;
            string[] words = inputString.Split(' ');

            for(int i=0; i < words.Length; i++)
            {
                currentWord = words[i];
                if (IsUpper(currentWord))
                {
                    sb.Append(currentWord);
                }
            }


            return sb.ToString();

        }

        private static bool IsUpper(string word)
        {
            char currentLetter;

            for (int i = 0; i < word.Length; i++)
            {
                currentLetter = word[i];

                if (!char.IsUpper(currentLetter)) {
                    return false;
                }
            }

            return true;
        }

        private static string SortStringAlphabetically(string inputString)
        {
            // An alternative to use would be Linq
            // Or implementing my own quicksort/mergesort
            // but found it unnecessary since Array.Sort() already uses a well optimized quick sort
            char[] sortableArray = inputString.ToCharArray();
            Array.Sort(sortableArray);
            return new string(sortableArray);
        }
    }
}
