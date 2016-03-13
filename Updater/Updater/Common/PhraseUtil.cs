using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater.Common
{
    static class PhraseUtil
    {
        private const string PHRASE_DATE_IDENTIFIER = "$dateIdentifier$";

        public static string ReplacePhrases(string text)
        {
            var dateIdentifier = DateTime.Now.ToString("yyyyMMdd");
            return text.Replace(PHRASE_DATE_IDENTIFIER, dateIdentifier);
        }
    }
}
