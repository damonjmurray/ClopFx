using System;
using System.Linq;
using ClopFx.Demo.Commands;

namespace ClopFx.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.Write("Enter your command:");
                args = Console.ReadLine().Split();
            }

            Engine.CreateNew()
                .WithCommand<PrintLogonName>()
                .Process(args);
        }
    }
}
