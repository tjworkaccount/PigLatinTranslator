using System;

namespace Translate
{
    public class Translator
    {
        private string InputString { get; set; }

        #region Constructors

        public Translator()
        {
            InputString = String.Empty;
        }

        public Translator(string input)
        {
            InputString = input;
        }

        #endregion

        #region Main Public Methods

        public void SetValue(string input)
        {
            InputString = string.IsNullOrWhiteSpace(input) ? string.Empty : input;
        }

        public string Translate()
        {
            return Parser.ParseWordStrings(InputString.Split(new char[] {' '}, StringSplitOptions.None));
        }

        #endregion
    }
}