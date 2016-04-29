using System.Collections.Generic;

namespace Paperview.Microformats.Album.Interfaces
{
    public interface IArtefacts
    {
        Dictionary<string, object> Title { get; set; }

        Dictionary<string, object> Description { get; set; }

        List<Image> Images { get; set; }
    }
}