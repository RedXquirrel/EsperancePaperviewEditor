using System;
using System.Collections.Generic;
using Paperview.Interfaces;

namespace Paperview.Common
{
    public class DocumentTypeMetaData : IDocumentTypeMetaData
    {
        public ILegal Legal { get; set; }

        public IPublisher Publisher { get; set; }

        public IAuthor Author { get; set; }

        private string _mfid;
        private string _docId;
        private string _presId;

        public string DocumentId
        {
            get { return _docId; }
            set { _docId = value.ToLowerInvariant(); }
        }

        public string MicroformatId
        {
            get { return _mfid; }
            set { _mfid = value.ToLowerInvariant(); }
        }

        public string PresentationId
        {
            get { return _presId; }
            set { _presId = value.ToLowerInvariant(); }
        }

        public string MicroformatIconBase64 { get; set; }
        public List<string> LanguageAvailability { get; set; }
        public string LanguageDefault { get; set; }
        public Dictionary<string, string> MicroformatName { get; set; }
        public Dictionary<string, string> MicroformatDescription { get; set; }

        public Microformat Microformat { get; set; }
    }
}
