using System.Collections.Generic;
using Paperview.Interfaces;

namespace Paperview.Common
{
    public class Microformat : IMicroformat
    {
        private string _mfid;

        public string Id
        {
            get { return _mfid; }
            set { _mfid = value.ToLowerInvariant(); }
        }

        public Dictionary<string, string> Name { get; set; }

        public Dictionary<string, string> Description { get; set; }

        public List<string> LanguageAvailability { get; set; }

        public string LanguageDefault { get; set; }

        public string Author { get; set; }

        public string AuthorEmailAddress { get; set; }

        public string AuthorWebAddress { get; set; }

        public string Derivation { get; set; }
    }
}
