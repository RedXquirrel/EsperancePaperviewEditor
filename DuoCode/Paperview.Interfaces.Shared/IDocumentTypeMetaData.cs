using System.Collections.Generic;

namespace Paperview.Interfaces
{
    public interface IDocumentTypeMetaData
    {
        ILegal Legal { get; set; }

        IPublisher Publisher { get; set; }

        IAuthor Author { get; set; }

        string DocumentTypeId { get; set; }
        string DocumentTypeIconBase64 { get; set; }
        List<string> LanguageAvailability { get; set; }
        string LanguageDefault { get; set; }

        Dictionary<string, string> DocumentTypeName { get; set; }
        Dictionary<string, string> DocumentTypeDescription { get; set; }
    }
}
