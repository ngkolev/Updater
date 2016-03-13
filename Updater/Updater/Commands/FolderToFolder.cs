using System;
using System.IO;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class FolderToFolder : CommandBase
    {
        public FolderToFolder(IOutput output) : base(output)
        {
        }

        public override string Name => "FolderToFolder";
        public override int ExpectedArguments => 2;

        public override void Execute(string[] arguments)
        {
            var source = arguments[0];
            var destination = arguments[1];
            foreach (string dirPath in Directory.GetDirectories(source, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(source, destination));

            foreach (string newPath in Directory.GetFiles(source, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(source, destination), true);
        }
    }
}