using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Paperview.Common;
using Paperview.Microformats.Album;

namespace Paperview.DocumentTypes.Album.ConsoleApplication
{
    class Program
    {
        private static AlbumMicroformat _albumMicroformat;

        static void Main(string[] args)
        {
            try
            {
                var microformat = new Microformat();

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

                var document = new Paperview.Common.Document();
                document.DocumentId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
                document.MicroformatId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
                document.PresentationId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
                document.LanguageAvailability = new List<string>(new[] { "en", "fr", "de", "es" });
                document.LanguageDefault = "en";
                document.MicroformatName = microformatName;
                document.MicroformatDescription = microformatDescription;
                document.Microformat = microformat;

                _albumMicroformat = new AlbumMicroformat()
                {
                    Document = document,
                };

                var json = JsonConvert.SerializeObject(_albumMicroformat);

                #endregion

            }
            catch (Exception ex)
            {
                

            }

        }
    }
}
