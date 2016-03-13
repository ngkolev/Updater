using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

        public override void Execute(string[] arguments)
        {
            var backupFile = PhraseUtil.ReplacePhrases(arguments[2]);
            var sqlScript =$"BACKUP DATABASE {arguments[1]} TO DISK = '{backupFile}'";

            using (var conn = new SqlConnection(arguments[0]))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sqlScript;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}