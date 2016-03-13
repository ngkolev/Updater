using System;
using System.Collections.Generic;
using System.Linq;
using Updater.Common;
using Updater.Exceptions;

namespace Updater.Core
{
    class CommandExecutor
    {
        public CommandExecutor(IOutput output)
        {
            Output = output;
        }

        private IOutput Output { get; }
        private ICollection<ICommand> Commands { get; set; }

        public int NumberOfCommands => Commands?.Count ?? 0;

        public void LoadCommands()
        {
            var type = typeof(ICommand);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !type.IsAbstract);

            Commands = types.Select(t => Activator.CreateInstance(t, Output)).OfType<ICommand>().ToList();
        }

        public void ExecuteCommand(string identifier, ICollection<string> arguments)
        {
            var command = Commands.SingleOrDefault(c => c.Name == identifier);
            if (command == null)
            {
                throw new CommandNotFoundException(identifier);
            }

            if (command.ExpectedArguments != arguments.Count)
            {
                throw new IncorrectNumberOfArgumentsException(identifier, command.ExpectedArguments, arguments.Count);
            }

            Output.WriteLine($"Executing command {identifier}");
            command.Execute(arguments);
        }
    }
}
