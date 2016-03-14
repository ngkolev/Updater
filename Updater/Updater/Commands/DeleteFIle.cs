using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class DeleteFile : CommandBase
    {
        public DeleteFile(IOutput output) : base(output)
        {
        }

        public override string Name => "DeleteFile";
        public override int ExpectedArguments => 1;

        public override void Execute(string[] arguments)
        {
            File.Delete(arguments[1]);
        }
    }
}
