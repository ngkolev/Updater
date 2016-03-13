using Updater.Common;
using Updater.Core;

namespace Updater
{
    class Executor
    {
        public Executor(ConsoleOutput consoleOutput, string scriptName)
        {
            Output = consoleOutput;
            ScriptName = scriptName;
        }

        private ConsoleOutput Output { get; }
        private string ScriptName { get; }

        public void Run()
        {
            // Load available commands
            Output.WriteLine("Loading available commands.");
            var executor = new CommandExecutor();
            executor.LoadCommands();
            Output.WriteLine($"{executor.NumberOfCommands} commands loaded.");

            // Parse
            Output.WriteLine("Reading script file.");
            var parser = new CommandParser(ScriptName);
            var commands = parser.Parse();

            // For each parsed command invoke the executor
            Output.WriteLine("Running script file.");
            foreach (var command in commands)
            {
                executor.ExecuteCommand(command.Identifier, command.Arguments);
            }
            Output.WriteLine("Done.");
        }
    }
}
