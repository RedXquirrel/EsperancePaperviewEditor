using System.Collections.Generic;

namespace Paperview.Microformats.Album.Interfaces
{
    public interface IImage
    {
        string Base64 { get; set; }

        Dictionary<string, string> Name { get; set; }

        Dictionary<string, string> Description { get; set; }
    }
}