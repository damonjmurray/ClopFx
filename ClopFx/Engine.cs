using System;
using System.Collections.Generic;
using System.Linq;
using ClopFx.EngineGrammar;

namespace ClopFx
{
    public class Engine : IRequireCommands, ICanBeProcessed
    {
        private readonly List<ICommandLineOperation> _commands;

        // force entry through static method
        private Engine()
        {
            _commands = new List<ICommandLineOperation>();
        }

        public static IRequireCommands CreateNew()
        {
            return new Engine();
        }

        public ICanBeProcessed WithCommand<T>() where T : ICommandLineOperation, new()
        {
            _commands.Add(new T());
            return this;
        }

        public IProcessable WithAllCommands()
        {
            var commands = AppDomain.CurrentDomain
                .GetAssemblies()
                .SelectMany(a => a.GetTypes().Where(t => t.IsAssignableFrom(typeof (ICommandLineOperation))));

            foreach (var command in commands)
            {
                _commands.Add((ICommandLineOperation) Activator.CreateInstance(command));
            }

            return this;
        }

        public ProcessResult Process(string[] args)
        {
            if (!_commands.Any())
                return new ProcessResult();  // not erroneous - simple doesn't need to do anything

            var commandSets = args.ToCommandSets();
            foreach (var set in commandSets)
            {
                //_commands.Single(c => c.CommandArgument.Equals(set[0])).Execute<>(set);
                _commands[0].Execute(set);
            }

            return new ProcessResult();
        }
    }
}
