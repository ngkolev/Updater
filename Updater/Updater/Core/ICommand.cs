using System.Collections.Generic;

namespace Updater.Core
{
    interface ICommand
    {
        string Name { get; }
        int ExpectedArguments { get; }
        void Execute(ICollection<string> arguments);
    }
}
