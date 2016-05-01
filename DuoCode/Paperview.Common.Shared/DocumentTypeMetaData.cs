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

        private string _documentTypeId;
        public string DocumentTypeId
        {
            get { return _documentTypeId; }
            set { _documentTypeId = value.ToLowerInvariant(); }
        }

        public string DocumentTypeIconBase64 { get; set; }
        public List<string> LanguageAvailability { get; set; }
        public string LanguageDefault { get; set; }

        public Dictionary<string, string> DocumentTypeName { get; set; }
        public Dictionary<string, string> DocumentTypeDescription { get; set; }
    }
}
