using System;
using System.Collections.Generic;

namespace Updater.Core
{
    class CommandParser
    {
        private readonly string _scriptFileName;

        public CommandParser(string scriptFileName)
        {
            _scriptFileName = scriptFileName;
            ScriptFileName = scriptFileName;
        }

        private string ScriptFileName { get; }

        public ICollection<CommandToken> Parse()
        {
            throw new NotImplementedException();
        }
    }
}
