using System;
using System.Collections.Generic;
using DuoCode.Dom;
using Paperview.Common;
using Paperview.Common.Ui;
using Paperview.Common.Ui.Helpers;
using Paperview.Interfaces;
using Paperview.Microformats.Album;

//using static DuoCode.Dom.Global; // uncomment to use C# 6.0 'using static' syntax

namespace Paperview.DocumentTypes.Album
{
    public class AlbumApplication
    {
        // tags
        private const string DivTagKey = "div";

        public AlbumApplication(HTMLElement rootElement)
        {
            var microformat = new Microformat();

            #region 
            // The following describes this specific DocumentType application.
            // The Microformat object above describes the user's specific instance of this Document Type.
            var microformatName = new Dictionary<string,string>();
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
            document.LanguageAvailability = new List<string>(new [] { "en", "fr", "de", "es" });
            document.LanguageDefault = "en";
            document.MicroformatName = microformatName;
            document.MicroformatDescription = microformatDescription;
            document.Microformat = microformat;
            #endregion

            var publisher = new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Esperance",
                Email = "anthony.harrison@xamtastic.com",
                Url = "http://www.esperance.com"
            };

            var albumMicroformat = new AlbumMicroformat()
            {
                Document = document,
                Publisher = publisher
            };

            //new PublisherPane(rootElement, publisher, Idiom.Phone);

            new Panel(rootElement, new PublisherPane(publisher, Idiom.Phone).GetContainer(), "Publisher", Idiom.Phone);



            //new Panel(rootElement, new DocumentTypePane(albumMicroformat.Document, Idiom.Desktop, "en").GetContainer(), "Document Type", Idiom.Desktop);
        }
    }

    static class Program
    {
        static void Run() // HTML body.onload event entry point, see index.html
        {
            var el = Global.document.getElementById("content");
            el.innerHTML = string.Empty;
            var albumApplication = new AlbumApplication(el);
        }
    }
}
