using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
