using System;
using Translate;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;

            do
            {
                var instructions = "Type \'exit\' to quit.\nInput:";
                Console.WriteLine(instructions);

                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                    isExit = true;

                Translator translator = new Translator(input);
                var results = $@"Result:{translator.Translate()}";
                Console.WriteLine(results);

            } while (!isExit);
        }
    }
}