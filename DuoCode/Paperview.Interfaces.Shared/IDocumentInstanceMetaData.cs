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

        string OriginalDocumentInstanceId { get; set; }
        string DocumentInstanceId { get; set; }
        string DocumentInstanceIconBase64 { get; set; }
        List<string> LanguageAvailability { get; set; }
        string LanguageDefault { get; set; }

        Dictionary<string, string> DocumentInstanceName { get; set; }
        Dictionary<string, string> DocumentInstanceDescription { get; set; }

        List<string> TranspositionHistory { get; set; } 

    }
}
