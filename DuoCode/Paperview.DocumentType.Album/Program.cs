using System;
using System.Collections.Generic;
using DuoCode.Dom;
using Paperview.Common;
using Paperview.Common.Ui;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Localisation;
using Paperview.Common.Ui.Models;
using Paperview.Interfaces;
using Paperview.Microformats.Album;

//using static DuoCode.Dom.Global; // uncomment to use C# 6.0 'using static' syntax

namespace Paperview.DocumentTypes.Album
{
    public class AlbumApplication
    {
        private Idiom _idiom;

        private string _initialisationJson;

        // The Microformat that is the basis of this Document Type
        private AlbumMicroformat _albumMicroformat;

        // Publisher Data
        public List<Publisher> _publishers;
        private int _selectedPublisherIndex;
        private Action<int> _selectPublisherAction;

        // Author Data
        public List<Author> _authors;
        private int _selectedauthorIndex;
        private Action<int> _selectAuthorsAction;

        // UI Root
        private HTMLElement _rootElement;

        // Publisher HTMLElements
        private PublisherPane _publisherPane;
        private LabelPane _publisherLabel;
        private DropDownPublishersListPane _dropDownPublishersList;

        // Author HTMLElements
        private LabelPane _authorLabel;
        private DropDownAuthorsListPane _dropDownAuthorsList;

        public AlbumApplication(HTMLElement rootElement, string initialisationJson)
        {
            _idiom = Idiom.Phone;

            _rootElement = rootElement;
            _initialisationJson = initialisationJson;

            // Define the action that will occur when a user selects a publisher
            _selectPublisherAction = index =>
            {
                _selectedPublisherIndex = (int) index;
                _albumMicroformat.DocumentInstanceMetaData.Publisher = (int) index >= 0 ? _publishers[_selectedPublisherIndex] : null;
                _publisherPane.Publisher = (Publisher)_albumMicroformat.DocumentInstanceMetaData.Publisher;
                _publisherLabel.Text = (int)index >= 0 ? $"{UiResources.PublisherLabelText} ({_albumMicroformat.DocumentInstanceMetaData.Publisher.Name})" : UiResources.PublisherLabelText;
            };

            // Define an action that will occur when a user selects an author
            _selectAuthorsAction = index =>
            {
                _selectedauthorIndex = (int)index;
                _albumMicroformat.DocumentInstanceMetaData.Author = (int)index >= 0 ? _authors[_selectedauthorIndex] : null;
                //_authorPane.Author = _albumMicroformat.Author;

                _authorLabel.Text = (int)index >= 0 ? $"{UiResources.AuthorLabelText} ({_albumMicroformat.DocumentInstanceMetaData.Author.Name})" : UiResources.AuthorLabelText;
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

            var document = new Paperview.Common.DocumentTypeMetaData();
            document.DocumentId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.MicroformatId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.PresentationId = "1878B000-77ED-417E-BE71-69CBFC716B3C";
            document.LanguageAvailability = new List<string>(new [] { "en", "fr", "de", "es" });
            document.LanguageDefault = "en";
            document.MicroformatName = microformatName;
            document.MicroformatDescription = microformatDescription;
            document.Microformat = microformat;

            _albumMicroformat = new AlbumMicroformat()
            {
                DocumentTypeMetaData = document,
                DocumentInstanceMetaData = new DocumentInstanceMetaData()
            };
            #endregion

            _publishers = new List<Publisher>();

            // ToDo: this is dummy data, waiting for it to be passed across a yet to be create HTML Bridge.
            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Esperance",
                Email = "esperance@xamtastic.com",
                Url = "http://www.esperance.chat"
            });

            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Xamtastic",
                Email = "xamtastic@xamtastic.com",
                Url = "http://www.xamtastic.com"
            });

            _publishers.Add(new Publisher()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Captain Xamtastic",
                Email = "thecaptain@captainxamtastic.com",
                Url = "http://www.captainxamtastic.com"
            });

            _authors = new List<Author>();

            // ToDo: this is dummy data, waiting for it to be passed across a yet to be create HTML Bridge.
            _authors.Add(new Author()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Anthony Harrison",
                Email = "anthony.harrison@esperance.chat",
                Url = "http://www.esperance.chat"
            });

            _authors.Add(new Author()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Anthony Harrison",
                Email = "anthony.harrison@xamtastic.com",
                Url = "http://www.xamtastic.com"
            });

            _authors.Add(new Author()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Captain Xamtastic",
                Email = "thecaptain@captainxamtastic.com",
                Url = "http://www.captainxamtastic.com"
            });





            #region Archive (tested)
            // new PublisherPane(rootElement, Idiom.Phone);
            //new PublisherPane(rootElement, publisher, Idiom.Phone);
            //new Panel(rootElement, new PublisherPane(publishers[0], Idiom.Phone).GetContainer(), "Publisher", Idiom.Phone);
            //new DocumentTypePane(rootElement, albumMicroformat.Document, Idiom.Phone, "en");
            //new Panel(rootElement, new DocumentTypePane(albumMicroformat.Document, Idiom.Desktop, "en").GetContainer(), "Document Type", Idiom.Desktop);

            // new DropDownListPane(rootElement, publishers, Idiom.Phone);
            //new Panel(rootElement, new DropDownPublishersListPane(_publishers, _selectPublisherAction, Idiom.Phone).GetContainer(), "Publisher", Idiom.Phone);
            #endregion

            DeclareUi();

            LayoutUi();
        }

        private void DeclareUi()
        {
            var myobj = Global.JSON.parse(_initialisationJson);
            System.Console.WriteLine((string)myobj.DocumentTypeMetaData.DocumentId);
            _publisherLabel = new LabelPane(UiResources.PublisherLabelText, _idiom) {TextCase = TextCase.Upper};
            _publisherPane = new PublisherPane(_idiom);
            _dropDownPublishersList = new DropDownPublishersListPane(_publishers, _selectPublisherAction, _idiom);

            _authorLabel = new LabelPane(UiResources.AuthorLabelText, _idiom) { TextCase = TextCase.Upper };
            _dropDownAuthorsList = new DropDownAuthorsListPane(_authors, _selectAuthorsAction, _idiom);
        }

        private void LayoutUi()
        {
            switch (_idiom)
            {
                case Idiom.Phone:
                    LayoutPhone();
                    break;
                case Idiom.Tablet:
                    LayoutTablet();
                    break;
                case Idiom.Desktop:
                    LayoutDesktop();
                    break;
                case Idiom.Unsupported:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void LayoutDesktop()
        {
            _rootElement.AppendChild(_publisherLabel.Container);
            _rootElement.AppendChild(_dropDownPublishersList.Container);
            _rootElement.AppendChild(_publisherPane.Container);
            _rootElement.AppendChild(_authorLabel.Container);
            _rootElement.AppendChild(_dropDownAuthorsList.Container);
        }

        private void LayoutTablet()
        {
            _rootElement.AppendChild(_publisherLabel.Container);
            _rootElement.AppendChild(_dropDownPublishersList.Container);
            _rootElement.AppendChild(_publisherPane.Container);
            _rootElement.AppendChild(_authorLabel.Container);
            _rootElement.AppendChild(_dropDownAuthorsList.Container);
        }

        private void LayoutPhone()
        {
            _rootElement.AppendChild(_publisherLabel.Container);
            _rootElement.AppendChild(_dropDownPublishersList.Container);
            _rootElement.AppendChild(_publisherPane.Container);
            _rootElement.AppendChild(_authorLabel.Container);
            _rootElement.AppendChild(_dropDownAuthorsList.Container);
        }
    }

    static class Program
    {
        static void Run(string documentTypeDescriptionJson)
        {
            System.Console.WriteLine(documentTypeDescriptionJson);

            var visualroot = Global.document.getElementById("content");
            visualroot.innerHTML = string.Empty;
            var albumApplication = new AlbumApplication(visualroot, documentTypeDescriptionJson);
        }
    }
}
