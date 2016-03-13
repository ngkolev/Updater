using System.Collections.Generic;

namespace Updater.Core
{
    class CommandToken
    {
        public CommandToken(string identifier, ICollection<string> arguments)
        {
            Identifier = identifier;
            Arguments = arguments;
        }

        public string Identifier { get; }
        public ICollection<string> Arguments { get; }
    }
}
