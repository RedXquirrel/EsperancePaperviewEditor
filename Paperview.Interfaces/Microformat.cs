using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public class Microformat : IMicroformat
    {
        private string _mfid;

        [JsonProperty(PropertyName = "mfid")]
        public string Id
        {
            get { return _mfid; }
            set { _mfid = value.ToLowerInvariant(); }
        }

        [JsonProperty(PropertyName = "mfname")]
        public Dictionary<string, string> Name { get; set; }

        [JsonProperty(PropertyName = "mfdescription")]
        public Dictionary<string, string> Description { get; set; }

        [JsonProperty(PropertyName = "mflanguageavailability")]
        public List<string> LanguageAvailability { get; set; }

        [JsonProperty(PropertyName = "mflanguagedefault")]
        public string LanguageDefault { get; set; }

        [JsonProperty(PropertyName = "mfauthor")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "mfauthoremailaddress")]
        public string AuthorEmailAddress { get; set; }

        [JsonProperty(PropertyName = "mfauthorwebaddress")]
        public string AuthorWebAddress { get; set; }

        [JsonProperty(PropertyName = "mfderivation")]
        public string Derivation { get; set; }


    }
}
