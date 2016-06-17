using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Translate
{
    public class Preserve
    {
        private const string PreserveValueStrings = ",!?";

        public bool IsPreserved(string word)
        {
            return string.IsNullOrWhiteSpace(word) || word.All(c => PreserveValueStrings.Contains(c.ToString()));
        }

        public string[] PreserveGrammar(string word)
        {
            var result = Regex.Split(word, @"([,?!])").Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            return result;
        }
    }
}