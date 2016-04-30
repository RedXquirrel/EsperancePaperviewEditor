using System;
using System.Collections.Generic;
using System.Text;

namespace Paperview.Interfaces.Shared
{
    public interface IDocumentInstanceMetaData
    {
        ILegal Legal { get; set; }

        IPublisher Publisher { get; set; }

        IAuthor Author { get; set; }
    }
}
