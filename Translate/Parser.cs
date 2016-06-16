using System.Collections.Generic;
using System.Linq;

namespace Translate
{
    public class Parser
    {
        public static string ParseWordStrings(IReadOnlyList<string> input)
        {
            var length = input.Count;
            var result = new string[length];

            for (var i = 0; i < length; i++)
            {
                result[i] = IsPreserved(input[i]) ? input[i] : ParseWord(input[i]);
            }

            return string.Join(" ", result);
        }

        public static bool IsPreserved(string word)
        {
            return string.IsNullOrWhiteSpace(word) ||
                   (string.Equals(word, ",") || (string.Equals(word, "!") || string.Equals(word, "?")));
        }

        public static string ParseWord(string word)
        {
            var result = @",!?".Any(word.Contains) ? ParseWordStrings(ParsePunctuation(word)) : TranslateWord(word);
            return result;
        }

        public static string[] ParsePunctuation(string word)
        {
            var result = new List<string>();

            return result.ToArray();
        }

        public static string TranslateWord(string word)
        {
            string result;

            if (char.IsUpper(word[0]))
            {
                var charArray = word.ToCharArray();
                charArray[0] = char.ToLower(charArray[0]);
                word = charArray.ToString();
                result = ConvertWord(word);
                charArray = result.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                result = charArray.ToString();
            }
            else
            {
                result = ConvertWord(word);
            }

            return result;
        }

        public static string ConvertWord(string word)
        {
            bool isVowel = @"aeiouyAEIOUY".Any(word.Contains);
            string prefix;
            string stem;

            string result = string.Empty;
            return result;
        }

    }
}