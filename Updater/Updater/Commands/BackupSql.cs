using System;
using System.Collections.Generic;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class BackupSql : CommandBase
    {
        public BackupSql(IOutput output) : base(output)
        {
        }

        public override string Name => "BackupSql";
        public override int ExpectedArguments => 3;

        public override void Execute(ICollection<string> arguments)
        {
            throw new NotImplementedException();
        }
    }
}