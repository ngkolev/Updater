using System;
using System.Collections.Generic;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class DeleteFolder : CommandBase
    {
        public DeleteFolder(IOutput output) : base(output)
        {
        }

        public override string Name => "DeleteFolder";
        public override int ExpectedArguments => 1;

        public override void Execute(ICollection<string> arguments)
        {
            throw new NotImplementedException();
        }
    }
}