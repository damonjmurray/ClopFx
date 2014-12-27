using System;
using System.Collections.Generic;
using System.Linq;

namespace ClopFx
{
    internal static class StringArrayExtensions
    {
        public static IEnumerable<string[]> ToCommandSets(this string[] args)
        {
            if (args == null)
                throw new ArgumentNullException("args");

            if (!args.Any())
                return new List<string[]>();

            if (!args.First().First().Equals(Globals.CommandSwitch))
                throw new Exception("Command line arguments must start with a command switch.");

            var index = 0;
            var commandSets = new List<string[]>();
            var set = new List<string>();

            do
            {
                if (index == args.Length || args[index].First().Equals(Globals.CommandSwitch))
                {
                    if (set.Any())
                        commandSets.Add(set.ToArray());

                    set = new List<string>();
                }

                set.Add(args[index]);
                index++;

                if (index == args.Length)
                    commandSets.Add(set.ToArray());

            } while (index < args.Length);

            return commandSets;
        }
    }
}