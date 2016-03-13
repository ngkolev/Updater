using System;
using System.Runtime.Serialization;

namespace Updater.Exceptions
{
    [Serializable]
    public class ScriptNotFoundException : UpdaterException
    {
        public ScriptNotFoundException()
            : base("Script not found")
        {
        }

        protected ScriptNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
