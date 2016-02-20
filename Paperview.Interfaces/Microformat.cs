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
        [JsonProperty(PropertyName = "mf-id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "mf-name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonProperty(PropertyName = "mf-description")]
        public Dictionary<string, string> Description { get; set; }

        [JsonProperty(PropertyName = "mf-language-availability")]
        public List<string> LanguageAvailability { get; set; }

        [JsonProperty(PropertyName = "mf-language-default")]
        public string LanguageDefault { get; set; }

        [JsonProperty(PropertyName = "mf-author")]
        public string Author { get; set; }

        [JsonProperty(PropertyName = "mf-author-emailaddress")]
        public string AuthorEmailAddress { get; set; }

        [JsonProperty(PropertyName = "mf-author-webaddress")]
        public string AuthorWebAddress { get; set; }

        [JsonProperty(PropertyName = "mf-derivation")]
        public string Derivation { get; set; }


    }
}
