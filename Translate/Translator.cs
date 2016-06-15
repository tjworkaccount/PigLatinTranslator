using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate
{
    public class Translator
    {
        private string InputString { get; }

        public Translator(string input)
        {
            InputString = input;
        }
        
        public string Translate()
        {
            throw new NotImplementedException();
        }

        protected bool Validate()
        {
            return String.IsNullOrWhiteSpace(InputString);
        }
    }
}