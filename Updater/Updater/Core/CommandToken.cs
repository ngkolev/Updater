namespace Updater.Core
{
    class CommandToken
    {
        public CommandToken(string identifier, string[] arguments)
        {
            Identifier = identifier;
            Arguments = arguments;
        }

        public string Identifier { get; }
        public string[] Arguments { get; }
    }
}
