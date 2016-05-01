using Paperview.Interfaces;
using Paperview.Interfaces.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paperview.Common
{
    public class DocumentInstanceMetaData : IDocumentInstanceMetaData
    {
        public ILegal Legal { get; set; }

        public IPublisher Publisher { get; set; }

        public IAuthor Author { get; set; }

        private string _originalDocumentInstanceId;

        /// <summary>
        /// When a document is transposed into another presentation format,
        /// the new one's OriginalDocumentInstanceId becomes the DocumentInstanceId
        /// of the one it is being transposed from (and yet the new, transposed document will
        /// get it's own, new and unique, DocumentId); this is so that numerous
        /// documents with the same OriginalDocumentId can be listed together,
        /// where the only difference between them is how they are presented. In
        /// the case that a document is being created instead of transposed, 
        /// it's OriginalDocumentInstanceId must be set to the DocumentInstanceId
        /// that was generated for it.
        /// </summary>
        public string OriginalDocumentInstanceId
        {
            get { return _originalDocumentInstanceId; }
            set { _originalDocumentInstanceId = value.ToLowerInvariant(); }
        }

        private string _documentInstanceId;
        public string DocumentInstanceId
        {
            get { return _documentInstanceId; }
            set { _documentInstanceId = value.ToLowerInvariant(); }
        }

        public string DocumentInstanceIconBase64 { get; set; }
        public List<string> LanguageAvailability { get; set; } = new List<string>();
        public string LanguageDefault { get; set; }

        public Dictionary<string, string> DocumentInstanceName { get; set; } = new Dictionary<string, string>();
        public Dictionary<string, string> DocumentInstanceDescription { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// When a document is transposed, it's Transposition history is copied across,
        /// with the PresentationId of the document being transposed from, added to the list.
        /// </summary>
        public List<string> TranspositionHistory { get; set; } = new List<string>();
    }
}
