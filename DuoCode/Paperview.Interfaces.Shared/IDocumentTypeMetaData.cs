using System.Collections.Generic;

namespace Paperview.Interfaces
{
    public interface IDocumentTypeMetaData
    {
        ILegal Legal { get; set; }

        IPublisher Publisher { get; set; }

        IAuthor Author { get; set; }

        string DocumentId { get; set; }
        string PresentationId { get; set; }

        string MicroformatId { get; set; }
        string MicroformatIconBase64 { get; set; }
        List<string> LanguageAvailability { get; set; }
        string LanguageDefault { get; set; }
        Dictionary<string, string> MicroformatName { get; set; }
        Dictionary<string, string> MicroformatDescription { get; set; }
    }
}
