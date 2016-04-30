using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paperview.Interfaces
{
    public interface IMicroformatService
    {
        // Service
        IDisposable CreateFactory();

        // Microformats
        void Create(object obj);
        void Close();

        // Documents
        string GetDocument(string docId);
        Dictionary<string, string> GetDocuments();
        void RemoveDocument(string docId);


    }
}
