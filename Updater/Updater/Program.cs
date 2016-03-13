using System;
using System.Linq;
using Updater.Common;

namespace Updater
{
    static class Program
    {
        static void Main(string[] args)
        {
            var output = new ConsoleOutput();

            if (args.Length != 1)
            {
                output.WriteLine("Expected *.upd script name as a command argument.");
            }
            else
            {
                try
                {
                    var executer = new Executor(output, args.Single());
                    executer.Run();
                }
                catch (Exception ex)
                {
                    output.WriteLine($"An exception has occurred. More details:{Environment.NewLine}{ex}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(false);
        }
    }
}
