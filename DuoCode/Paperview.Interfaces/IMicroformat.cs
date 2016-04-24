using System.Collections.Generic;

namespace Paperview.Interfaces
{
    public interface IMicroformat
    {
        string Id { get; set; }
        Dictionary<string, string> Name { get; set; }
        Dictionary<string, string> Description { get; set; }
        List<string> LanguageAvailability { get; set; }
        string LanguageDefault { get; set; }
        string Author { get; set; }
        string AuthorEmailAddress { get; set; }
        string Derivation { get; set; }
    }
}