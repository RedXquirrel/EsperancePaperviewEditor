using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public interface IDocument
    {
        string DocumentId { get; set; }

        string MicroformatId { get; set; }

        string PresentationId { get; set; }
    }
}
