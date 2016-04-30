using Paperview.Common;
using Paperview.Common.Shared;
using Paperview.Interfaces;

namespace Paperview.Microformats.Album
{
    public class AlbumMicroformat
    {
        public DocumentTypeMetaData DocumentTypeMetaData { get; set; }

        public DocumentInstanceMetaData DocumentInstanceMetaData { get; set; }

        public Artefacts Artifacts { get; set; }
    }
}
