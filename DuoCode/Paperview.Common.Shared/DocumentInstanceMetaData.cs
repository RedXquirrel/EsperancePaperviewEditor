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
    }
}
