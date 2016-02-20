using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Esperance.Paperview.Core.Services
{
    public class ServiceError
    {
        public Type Type { get; set; }
        public object Cache { get; set; }
        public string ErrorMessage { get; set; }
    }
}
