using System.Diagnostics;
using Updater.Common;

namespace Updater.Core
{
    class Executor
    {
        public Executor(IOutput consoleOutput, string scriptFileName)
        {
            Output = consoleOutput;
            ScriptFileName = scriptFileName;
        }

        private IOutput Output { get; }
        private string ScriptFileName { get; }

        public void Run()
        {
            var watch = Stopwatch.StartNew();

            // Load available commands
            Output.WriteLine("Loading available commands.");
            var executor = new CommandExecutor(Output);
            executor.LoadCommands();
            Output.WriteLine($"{executor.NumberOfCommands} commands loaded.");

            // Parse
            Output.WriteLine("Reading script file.");
            var parser = new CommandParser(ScriptFileName);
            var commands = parser.Parse();

            // For each parsed command invoke the executor
            Output.WriteLine("Running script file.");
            foreach (var command in commands)
            {
                executor.ExecuteCommand(command.Identifier, command.Arguments);
            }

            Output.WriteLine($"Done for {watch.ElapsedMilliseconds} ms.");
        }
    }
}
