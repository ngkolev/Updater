using System;
using System.Collections.Generic;
using System.IO;
using Updater.Common;
using Updater.Core;

namespace Updater.Commands
{
    class CleanFolder : CommandBase
    {
        public CleanFolder(IOutput output) : base(output)
        {
        }

        public override string Name => "CleanFolder";
        public override int ExpectedArguments => 2;

        public override void Execute(string[] arguments)
        {
            ClearSubDirectory(arguments[0], arguments[1]);
        }

        private static void ClearSubDirectory(string sourceDirectory, string fileExtensionToRemove)
        {
            // Remove files in this directory
            ClearDirectory(sourceDirectory, fileExtensionToRemove);

            // Go through sub directories
            foreach (string directory in Directory.GetDirectories(sourceDirectory))
            {
                ClearSubDirectory(directory, fileExtensionToRemove);
            }
        }

        private static void ClearDirectory(string sourceDirectory, string fileExtensionToRemove)
        {
            foreach (var fileName in Directory.GetFiles(sourceDirectory))
            {
                var extension = Path.GetExtension(fileName)?.Replace(".", "");
                if (extension == fileExtensionToRemove)
                {
                    File.Delete(fileName);
                }
            }
        }
    }
}