using System.Collections.Generic;
using Newtonsoft.Json;
using Paperview.Common;

namespace Paperview.DocumentTypes.Album.T4
{
    // The purpose of this class is just to make sure that 
    // the dlls are copied to the Debug folder when the project is built.
    public class InitialiseDlls
    {
        public InitialiseDlls()
        {
            //var microformatName = new Dictionary<string, string>();
            //microformatName.Add("en", "Album");
            //microformatName.Add("fr", "tbt");
            //microformatName.Add("de", "tbt");
            //microformatName.Add("es", "tbt");

            //var a = JsonConvert.SerializeObject(microformatName);
            //var b = new Document();

            ////

            //var xmicroformatName = new Dictionary<string, string>();
            //xmicroformatName.Add("en", "Album");
            //xmicroformatName.Add("fr", "tbt");
            //xmicroformatName.Add("de", "tbt");
            //xmicroformatName.Add("es", "tbt");

            //var a = JsonConvert.SerializeObject(xmicroformatName);

            #region 
            // The following describes this specific DocumentType application.
            // The Microformat object above describes the user's specific instance of this Document Type.
            var microformatName = new Dictionary<string, string>();
            microformatName.Add("en", "Album");
            microformatName.Add("fr", "tbt");
            microformatName.Add("de", "tbt");
            microformatName.Add("es", "tbt");

            var microformatDescription = new Dictionary<string, string>();
            microformatDescription.Add("en", "An Image Album");
            microformatDescription.Add("fr", "tbt");
            microformatDescription.Add("de", "tbt");
            microformatDescription.Add("es", "tbt");

            var document = new Document();
            document.DocumentId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.MicroformatId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.PresentationId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.LanguageAvailability = new List<string>(new[] { "en", "fr", "de", "es" });
            document.LanguageDefault = "en";
            document.MicroformatName = microformatName;
            document.MicroformatDescription = microformatDescription;
            //document.Microformat = microformat;
            #endregion

            var a = JsonConvert.SerializeObject(document);
        }
    }
}
