using System;
using Translate;

namespace Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var isExit = false;

            while (!isExit)
            {
                Console.WriteLine("Type \'exit\' to quit.\nInput:");

                var input = Console.ReadLine();

                if (input?.ToLower() != "exit")
                {
                    var translator = new Translator(input);
                    Console.WriteLine($"Result:\n{translator.Translate()}");
                }
                else
                {
                    isExit = true;
                }
            }
        }
    }
}