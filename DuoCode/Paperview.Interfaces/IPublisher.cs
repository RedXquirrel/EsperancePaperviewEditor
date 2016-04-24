using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public interface IPublisher
    {
        string Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Url { get; set; }
    }
}
