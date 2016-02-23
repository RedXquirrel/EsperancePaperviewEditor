using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public class Root : IPaperviewMicroformatRoot
    {
        public Document Document { get; set; }
    }
}
