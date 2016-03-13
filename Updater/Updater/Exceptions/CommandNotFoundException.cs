using System;
using System.Runtime.Serialization;
using Updater.Core;

namespace Updater.Exceptions
{
    [Serializable]
    public class CommandNotFoundException : UpdaterException
    {
        public CommandNotFoundException(string commandName)
            : base("Command not found")
        {
            CommandName = commandName;
        }

        public string CommandName { get; }

        protected CommandNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}