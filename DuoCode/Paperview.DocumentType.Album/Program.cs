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
        public List<Publisher> _publishers;
        private Publisher _selectedPublisher;
        private Action<int> _selectPublisherAction;

        private PublisherPane _publisherPane;

        public AlbumApplication(HTMLElement rootElement)
        {
            _selectPublisherAction = publisherId =>
            {
                System.Console.WriteLine($"xSelected Index: {publisherId}");

                if ((int)publisherId >= 0)
                {
                    System.Console.WriteLine($"XXSelected Publisher: {_publishers[publisherId].Name}");
                    _publisherPane.DataSource = _publishers[publisherId];
                }
                else
                {
                    _publisherPane.DataSource = null;
                }
            };

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

            _publishers = new List<Publisher>();

            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Esperance",
                Email = "anthony.harrison@xamtastic.com",
                Url = "http://www.esperance.chat"
            });

            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Xamtastic",
                Email = "anthony.harrison@xamtastic.com",
                Url = "http://www.xamtastic.com"
            });

            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Captain Xamtastic",
                Email = "anthony.harrison@captainxamtastic.com",
                Url = "http://www.captainxamtastic.com"
            });



            var albumMicroformat = new AlbumMicroformat()
            {
                Document = document,
                Publisher = _publishers[0]
            };

            // new PublisherPane(rootElement, Idiom.Phone);
            //new PublisherPane(rootElement, publisher, Idiom.Phone);
            //new Panel(rootElement, new PublisherPane(publishers[0], Idiom.Phone).GetContainer(), "Publisher", Idiom.Phone);
            //new DocumentTypePane(rootElement, albumMicroformat.Document, Idiom.Phone, "en");
            //new Panel(rootElement, new DocumentTypePane(albumMicroformat.Document, Idiom.Desktop, "en").GetContainer(), "Document Type", Idiom.Desktop);

            // new DropDownListPane(rootElement, publishers, Idiom.Phone);
            new Panel(rootElement, new DropDownPublishersListPane(_publishers, _selectPublisherAction, Idiom.Phone).GetContainer(), "Publisher", Idiom.Phone);
            _publisherPane = new PublisherPane(rootElement, Idiom.Phone);
        }
    }

    static class Program
    {
        static void Run() // HTML body.onload event entry point, see index.html
        {
            System.Console.WriteLine("Hello DuoCode");

            var el = Global.document.getElementById("content");
            el.innerHTML = string.Empty;
            var albumApplication = new AlbumApplication(el);
        }
    }
}
