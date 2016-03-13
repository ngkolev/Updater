namespace Updater.Core
{
    interface ICommand
    {
        string Name { get; }
        void Execute(string[] arguments);
    }
}
