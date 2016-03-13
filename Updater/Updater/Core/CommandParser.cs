using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Updater.Exceptions;

namespace Updater.Core
{
    class CommandParser
    {
        private const string SYMBOL_COMMENT = "#";

        public CommandParser(string scriptFileName)
        {
            ScriptFileName = scriptFileName;
        }

        private string ScriptFileName { get; }

        public ICollection<CommandToken> Parse()
        {
            var content = ReadFile();
            var lines = content
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries) // Split by lines
                .Select(l => l.Trim())                                                // Handle lines that contains only spaces
                .Where(l => l != "" && !l.StartsWith(SYMBOL_COMMENT));                // Remove empty lines and comment lines

            var commandTokens = lines.Select(l =>
            {
                var tokens = l.Split('\t');
                var command = tokens.First();
                var arguments = tokens.Skip(1).ToList();
                return new CommandToken(command, arguments);
            });

            return commandTokens.ToList();
        }

        private string ReadFile()
        {
            if (!File.Exists(ScriptFileName))
            {
                throw new ScriptNotFoundException();
            }

            using (var stream = File.OpenRead(ScriptFileName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
