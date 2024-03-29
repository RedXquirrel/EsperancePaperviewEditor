﻿using Newtonsoft.Json;
using Paperview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0
{
    public class Microformat_B9889DB4_9D9A_4857_841B_CD5EB8E72FF0 : IPaperviewMicroformatRoot
    {
        [JsonProperty(PropertyName = "document")]
        public Document Document { get; set; }

        [JsonProperty(PropertyName = "legal")]
        public Legal Legal { get; set; }

        [JsonProperty(PropertyName = "publisher")]
        public Publisher Publisher { get; set; }

        [JsonProperty(PropertyName = "artifacts")]
        public Artifacts Artifacts { get; set; }
    }
}
