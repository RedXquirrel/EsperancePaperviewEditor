using System;
using System.IO;
using System.Reflection;
using Paperview.Interfaces;

namespace Chat.Esperance.PaperviewTests
{
    public class MockMicroformatTemplateService : IMicroformatTemplateService
    {
        public string Get(Guid templateId)
        {
            return GetFile($"Chat.Esperance.PaperviewTests.Html5.Templates.{templateId.ToString().ToUpperInvariant()}.html");
        }

        private static string GetFile(string fileName)
        {
            var assembly = typeof(MockMicroformatTemplateService).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream(fileName);
            var text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
    }
}