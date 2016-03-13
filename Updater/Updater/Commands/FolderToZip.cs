using System;
using System.Collections.Generic;
using System.IO.Compression;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class FolderToZip : CommandBase
    {
        public FolderToZip(IOutput output) : base(output)
        {
        }

        public override string Name => "FolderToZip";
        public override int ExpectedArguments => 2;

        public override void Execute(string[] arguments)
        {
            ZipFile.CreateFromDirectory(arguments[0], arguments[1]);
        }
    }
}