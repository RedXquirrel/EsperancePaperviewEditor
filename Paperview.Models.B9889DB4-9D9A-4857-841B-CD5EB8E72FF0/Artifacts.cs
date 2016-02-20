using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Models.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0
{
    public class Artifacts
    {
        [JsonProperty(PropertyName = "title")]
        public Dictionary<string, object> Title { get; set; }

        [JsonProperty(PropertyName = "description")]
        public Dictionary<string, object> Description { get; set; }

        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }
    }
}
