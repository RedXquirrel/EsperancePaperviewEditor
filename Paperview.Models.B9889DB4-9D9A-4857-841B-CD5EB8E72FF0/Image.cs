using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0
{
    public class Image
    {
        [JsonProperty(PropertyName = "base64")]
        public string Base64 { get; set; }


        [JsonProperty(PropertyName = "name")]
        public Dictionary<string, string> Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public Dictionary<string, string> Description { get; set; }

    }
}
