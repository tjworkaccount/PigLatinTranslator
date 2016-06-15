using System;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;

            do
            {
                Console.WriteLine("Type 'exit' to quit.");
                Console.WriteLine("Input:");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    if (input.ToLower() == "exit")
                    {
                        isExit = true;
                    }
                    else
                    {
                        Console.WriteLine("Output:");
                        //Console.WriteLine(Translator.Translate(input));
                        Console.WriteLine();
                    }
                }
            } while (!isExit);
        }
    }
}
