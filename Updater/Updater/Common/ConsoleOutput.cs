using System;

namespace Updater.Common
{
    class ConsoleOutput : IOutput
    {
        public void Write(string text, params object[] args)
        {
            Console.Write(text, args);
        }

        public void WriteLine(string text, params object[] args)
        {
            Console.WriteLine(text, args);
        }
    }
}
