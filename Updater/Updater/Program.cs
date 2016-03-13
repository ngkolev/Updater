using System;
using System.Linq;
using Updater.Common;
using Updater.Core;
using Updater.Exceptions;

namespace Updater
{
    static class Program
    {
        private const string FILE_EXTENSIONS = "upd";

        static void Main(string[] args)
        {
            var output = new ConsoleOutput();

            if (args.Length != 1)
            {
                output.WriteLine($"Expected *.{FILE_EXTENSIONS} script name as a command argument.");
            }
            else
            {
                var scriptName = $"{args.Single()}.{FILE_EXTENSIONS}";
                ExecuteInternal(output, scriptName);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(false);
        }

        private static void ExecuteInternal(ConsoleOutput output, string scriptFileName)
        {
            try
            {
                var executer = new Executor(output, scriptFileName);
                executer.Run();
            }
            catch (ScriptNotFoundException)
            {
                output.WriteLine($"A script with name {scriptFileName} was not found");
            }
            catch (CommandNotFoundException ex)
            {
                output.WriteLine($"Command with name {ex.CommandName} cannot be found");
            }
            catch (IncorrectNumberOfArgumentsException ex)
            {
                output.WriteLine($"Incorrect number of arguments for command {ex.CommandName}. It expects {ex.Expected} but has been provided {ex.Provided}");
            }
            catch (Exception ex)
            {
                output.WriteLine($"An unhandled exception has occurred. More details:{Environment.NewLine}{ex}");
            }
        }
    }
}
