using System;
using System.Collections.Generic;

namespace Updater.Core
{
    class CommandParser
    {
        public CommandParser(string scriptName)
        {
            ScriptName = scriptName;
        }

        private string ScriptName { get; }

        public ICollection<CommandToken> Parse()
        {
            throw new NotImplementedException();
        }
    }
}
