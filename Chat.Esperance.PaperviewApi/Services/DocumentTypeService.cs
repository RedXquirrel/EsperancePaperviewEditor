using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.PaperviewApi.Interfaces;
using Paperview.StockDocumentTypes;

namespace Chat.Esperance.PaperviewApi.Services
{
    public class DocumentTypeService : IDocumentTypeService
    {
        public List<string> GetDocumentTypes()
        {
            List<string> docs = new List<string>();

            var assembly = typeof(StockDocumentTypes).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Paperview.StockDocumentTypes.index.html");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            docs.Add(text);

            return docs;
        }
    }
}
