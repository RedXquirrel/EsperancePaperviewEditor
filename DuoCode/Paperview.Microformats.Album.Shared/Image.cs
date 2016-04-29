using System.Collections.Generic;
using Paperview.Microformats.Album.Interfaces;

namespace Paperview.Microformats.Album
{
    public class Image : IImage
    {
        public string Base64 { get; set; }

        public Dictionary<string, string> Name { get; set; }

        public Dictionary<string, string> Description { get; set; }
    }
}