using System;
using System.Runtime.Serialization;

namespace Updater.Exceptions
{
    [Serializable]
    public class IncorrectNumberOfArgumentsException : UpdaterException
    {
        public IncorrectNumberOfArgumentsException(string commandName, int expected, int provided)
            : base("Incorrect number of arguments")
        {
            CommandName = commandName;
            Expected = expected;
            Provided = provided;
        }

        public string CommandName { get; }
        public int Expected { get; }
        public int Provided { get; }

        protected IncorrectNumberOfArgumentsException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}