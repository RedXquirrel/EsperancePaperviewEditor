﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public class Document : IDocument
    {
        private string _mfid;

        [JsonProperty(PropertyName = "documentId")]
        public string DocumentId { get; set; }

        [JsonProperty(PropertyName = "microformatId")]
        public string MicroformatId
        {
            get { return _mfid; }
            set { _mfid = value.ToLowerInvariant(); }
        }

        [JsonProperty(PropertyName = "presentationId")]
        public string PresentationId { get; set; }


        [JsonProperty(PropertyName = "microformat")]
        public Microformat Microformat { get; set; }
    }
}
