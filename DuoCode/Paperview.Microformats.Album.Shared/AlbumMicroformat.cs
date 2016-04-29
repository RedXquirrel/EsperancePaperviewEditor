using Paperview.Common;
using Paperview.Interfaces;

namespace Paperview.Microformats.Album
{
    public class AlbumMicroformat
    {
        public Legal Legal { get; set; }

        public Publisher Publisher { get; set; }

        public Author Author { get; set; }

        public Document Document { get; set; }

        public Artefacts Artifacts { get; set; }
    }
}
