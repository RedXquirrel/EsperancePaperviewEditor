using Paperview.Common;
using Paperview.Interfaces;

namespace Paperview.Microformats.Album
{
    public class AlbumMicroformat
    {
        public Document Document { get; set; }

        public Legal Legal { get; set; }

        public Publisher Publisher { get; set; }

        public Artefacts Artifacts { get; set; }
    }
}
