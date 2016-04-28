using System;
using DuoCode.Dom;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class PublisherPane : IHtmlElement
    {
        // Data
        private Idiom _idiom;
        private Publisher _publisher;

        // UI
        private readonly HTMLElement _parent;
        private HTMLElement _container;

        // tags
        private const string DivTagKey = "div";
        private const string TableTagKey = "table";
        private const string TableRowKey = "tr";
        private const string TableCellKey = "td";

        // attribute values
        private const string TableClassKey = "standardNameValuePairTable";
        private const string NameCellClassKey = "standardNamePairCell";
        private const string ValueCellClassKey = "standardValuePairCell";

        // misc
        private string _nbspaceKey = "&nbsp;";

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        public PublisherPane(Idiom idiom)
        {
            _idiom = idiom;
            Initialise(new Publisher() { Id = _nbspaceKey, Name = _nbspaceKey, Email = _nbspaceKey, Url = _nbspaceKey }, idiom);
        }

        public PublisherPane(Publisher publisher, Idiom idiom)
        {
            _idiom = idiom;
            Initialise(publisher, idiom);
        }

        public PublisherPane(HTMLElement parent, Idiom idiom)
        {
            _parent = parent;
            _idiom = idiom;
            Initialise(new Publisher() { Id = _nbspaceKey, Name = _nbspaceKey, Email = _nbspaceKey, Url = _nbspaceKey }, idiom);
        }

        public PublisherPane(HTMLElement parent, Publisher publisher, Idiom idiom)
        {
            _parent = parent;
            _idiom = idiom;
            Initialise(publisher, idiom);
        }

        public Publisher Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
                Initialise(_publisher != null ? Publisher : new Publisher() {Id = _nbspaceKey, Name = _nbspaceKey, Email = _nbspaceKey, Url = _nbspaceKey}, _idiom);
            }
        }

        private void Initialise(Publisher publisher, Idiom idiom)
        {
            _publisher = publisher;

            if (_container == null)
            {
                _container = Hx.CreateDivElement();
            }
            else
            {
                _container.InnerHtml(string.Empty);
            }

            switch (idiom)
            {
                case Idiom.Phone:
                    CreateStack(idiom);
                    break;
                case Idiom.Tablet:
                    CreateTable(idiom);
                    break;
                case Idiom.Desktop:
                    CreateTable(idiom);
                    break;
                case Idiom.Unsupported:
                    CreateTable(idiom);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(idiom), idiom, null);
            }
        }

        private void CreateStack(Idiom idiom)
        {
            _container
                .AppendChild(Hx.CreateDivElement().InnerHtml(UiResources.PublisherIdLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(_publisher.Id).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(UiResources.PublisherNameLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(_publisher.Name).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(UiResources.PublisherEmailAddressLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(_publisher.Email).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(UiResources.PublisherWebAddressLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                .AppendChild(Hx.CreateDivElement().InnerHtml(_publisher.Url).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom)));

            _parent?.appendChild(_container);
        }

        private void CreateTable(Idiom idiom)
        {
            _container.AppendChild(
                Hx.CreateTableElement().SetAttribute(Hx.ClassAttKey, TableClassKey.AppendIdiomString(idiom))
                .AppendChild(Hx.CreateTrElement()
                                .AppendChild(Hx.CreateTdElement().InnerHtml(UiResources.PublisherIdLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                                .AppendChild(Hx.CreateTdElement().InnerHtml(_publisher.Id).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom))))
                .AppendChild(Hx.CreateTrElement()
                                .AppendChild(Hx.CreateTdElement().InnerHtml(UiResources.PublisherNameLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                                .AppendChild(Hx.CreateTdElement().InnerHtml(_publisher.Name).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom))))
                .AppendChild(Hx.CreateTrElement()
                                .AppendChild(Hx.CreateTdElement().InnerHtml(UiResources.PublisherEmailAddressLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                                .AppendChild(Hx.CreateTdElement().InnerHtml(_publisher.Email).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom))))
                .AppendChild(Hx.CreateTrElement()
                                .AppendChild(Hx.CreateTdElement().InnerHtml(UiResources.PublisherWebAddressLabel).SetAttribute(Hx.ClassAttKey, NameCellClassKey.AppendIdiomString(idiom)))
                                .AppendChild(Hx.CreateTdElement().InnerHtml(_publisher.Url).SetAttribute(Hx.ClassAttKey, ValueCellClassKey.AppendIdiomString(idiom))))
                );

            _parent?.appendChild(_container);
        }
    }
}
