using System.Collections.Generic;
using Paperview.Microformats.Album.Interfaces;

namespace Paperview.Microformats.Album
{
    public class Artefacts : IArtefacts
    {
        public Dictionary<string, object> Title { get; set; }

        public Dictionary<string, object> Description { get; set; }

        public List<Image> Images { get; set; }
    }
}