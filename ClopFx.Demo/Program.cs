using System;
using System.Linq;
using ClopFx.Demo.Commands;

namespace ClopFx.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var engine = Engine.CreateNew()
                .WithCommand<PrintLogonName>()
                .OutputTo(Console.Out);

            args = GetCommandLineArgument(args);
            while (engine.Process(args) != ProcessResult.Completed)
            {
                engine.Process(args);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static string[] GetCommandLineArgument(string[] args)
        {
            if (args != null && args.Any())
                return args;
            
            string input;
            do
            {
                Console.Write("Enter your command: ");
            } while (string.IsNullOrEmpty(input = Console.ReadLine()));

            return input.Split();
        }
    }
}
