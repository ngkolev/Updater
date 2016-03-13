using System;
using System.Collections.Generic;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class ZipToFolder : CommandBase
    {
        public ZipToFolder(IOutput output) : base(output)
        {
        }

        public override string Name => "ZipToFolder";
        public override int ExpectedArguments => 2;

        public override void Execute(ICollection<string> arguments)
        {
            throw new NotImplementedException();
        }
    }
}
