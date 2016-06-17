using System;
using System.Collections.Generic;
using System.Linq;

namespace Translate
{
    public class Parser
    {
        private Preserve Preserve { get; } = new Preserve();

        public string ParseStrings(IReadOnlyList<string> input, bool isSpaced = true)
        {
            var length = input.Count;
            var result = new string[length];

            for (var i = 0; i < length; i++)
            {
                result[i] = Preserve.IsPreserved(input[i]) ? input[i] : ParseWord(input[i]);
            }

            return isSpaced ? string.Join(" ", result) : result.ToString();
        }
        
        public string ParseWord(string word)
        {
            return @",!?".Any(word.Contains) ? ParseStrings(Preserve.PreserveGrammar(word), false) : FormatWord(word);
        }

        public string FormatWord(string word)
        {
            var isCapitalized = char.IsUpper(word[0]);

            if (!isCapitalized)
            {
                return TranslateWord(word);
            }

            var charArray = word.ToCharArray();
            charArray[0] = char.ToLower(charArray[0]);            
            charArray = TranslateWord(new string(charArray)).ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }
        
        public string TranslateWord(string word)
        {
            var result = SplitWord(word);

            return string.IsNullOrWhiteSpace(result.Key) ? result.Value : $"{result.Key}{result.Value}";
        }

        private static KeyValuePair<string, string> SplitWord(string word)
        {
            var result = new KeyValuePair<string, string>();
            const string vowelString = "aeiouyAEIOUY";
            if (vowelString.Any(word.Contains))
            {
                var index = word.IndexOfAny(vowelString.ToCharArray());
                var prefix = word.Substring(0, index) + "ay";
                var seed = word.Substring(index);
                result = new KeyValuePair<string, string>(seed, prefix);
            }
            else
            {
                result = new KeyValuePair<string, string>(string.Empty, word + "yay");
            }

            return result;
        }
    }
}