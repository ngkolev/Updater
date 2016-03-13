using System.Collections.Generic;
using Updater.Common;

namespace Updater.Core
{
    abstract class CommandBase : ICommand
    {
        protected CommandBase(IOutput output)
        {
            Output = output;
        }

        private IOutput Output { get; }

        public abstract string Name { get; }
        public abstract int ExpectedArguments { get; }

        public abstract void Execute(string[] arguments);
    }
}
