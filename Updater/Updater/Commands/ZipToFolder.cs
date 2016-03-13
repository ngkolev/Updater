using System;
using System.Collections.Generic;
using System.IO.Compression;
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

        public override void Execute(string[] arguments)
        {
            ZipFile.ExtractToDirectory(arguments[0], arguments[1]);
        }
    }
}
