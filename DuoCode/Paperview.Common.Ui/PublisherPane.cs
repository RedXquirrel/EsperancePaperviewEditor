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

        // attribute names
        private const string ClassAttributeKey = "class";

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

        private Publisher _dataSource;

        public Publisher DataSource
        {
            get { return _dataSource; }
            set
            {
                _dataSource = value;
                Initialise(_dataSource != null ? DataSource : new Publisher() {Id = _nbspaceKey, Name = _nbspaceKey, Email = _nbspaceKey, Url = _nbspaceKey}, _idiom);
            }
        }

        private void Initialise(Publisher publisher, Idiom idiom)
        {
            _publisher = publisher;

            if (_container == null)
            {
                _container = Global.document.createElement(DivTagKey);
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

            var idLabelElement = Global.document.createElement(DivTagKey);
            idLabelElement.innerHTML = UiResources.PublisherIdLabel;
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(DivTagKey);
            idValueElement.innerHTML = _publisher.Id;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(idValueElement);

            var nameLabelElement = Global.document.createElement(DivTagKey);
            nameLabelElement.innerHTML = UiResources.PublisherNameLabel;
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(nameLabelElement);

            var nameValueElement = Global.document.createElement(DivTagKey);
            nameValueElement.innerHTML = _publisher.Name;
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(nameValueElement);

            var emailAddressLabelElement = Global.document.createElement(DivTagKey);
            emailAddressLabelElement.innerHTML = UiResources.PublisherEmailAddressLabel;
            emailAddressLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(emailAddressLabelElement);

            var emailAddressValueElement = Global.document.createElement(DivTagKey);
            emailAddressValueElement.innerHTML = _publisher.Email;
            emailAddressValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(emailAddressValueElement);

            var urlLabelElement = Global.document.createElement(DivTagKey);
            urlLabelElement.innerHTML = UiResources.PublisherWebAddressLabel;
            urlLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(urlLabelElement);

            var urlValueElement = Global.document.createElement(DivTagKey);
            urlValueElement.innerHTML = _publisher.Url;
            urlValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            _container.appendChild(urlValueElement);

            _parent?.appendChild(_container);
        }

        private void CreateTable(Idiom idiom)
        {
            var tableElement = Global.document.createElement(TableTagKey);
            tableElement.setAttribute(ClassAttributeKey, TableClassKey.AppendIdiomString(idiom));

            var row1Element = Global.document.createElement(TableRowKey);

            var idLabelElement = Global.document.createElement(TableCellKey);
            idLabelElement.innerHTML = "Id";
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            row1Element.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(TableCellKey);
            idValueElement.innerHTML = _publisher.Id;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            row1Element.appendChild(idValueElement);

            var row2Element = Global.document.createElement(TableRowKey);

            var nameLabelElement = Global.document.createElement(TableCellKey);
            nameLabelElement.innerHTML = "Name";
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            row2Element.appendChild((nameLabelElement));

            var nameValueElement = Global.document.createElement(TableCellKey);
            nameValueElement.innerHTML = _publisher.Name;
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            row2Element.appendChild(nameValueElement);

            var row3Element = Global.document.createElement(TableRowKey);

            var emailLabelElement = Global.document.createElement(TableCellKey);
            emailLabelElement.innerHTML = "Email";
            emailLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            row3Element.appendChild(emailLabelElement);

            var emailValueElement = Global.document.createElement(TableCellKey);
            emailValueElement.innerHTML = _publisher.Email;
            emailValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            row3Element.appendChild(emailValueElement);

            var row4Element = Global.document.createElement(TableRowKey);

            var urlLabelElement = Global.document.createElement(TableCellKey);
            urlLabelElement.innerHTML = "Web Address";
            urlLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey.AppendIdiomString(idiom));
            row4Element.appendChild((urlLabelElement));

            var urlValueElement = Global.document.createElement(TableCellKey);
            urlValueElement.innerHTML = _publisher.Url;
            urlValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey.AppendIdiomString(idiom));
            row4Element.appendChild(urlValueElement);

            tableElement.appendChild(row1Element);
            tableElement.appendChild(row2Element);
            tableElement.appendChild(row3Element);
            tableElement.appendChild(row4Element);

            _container.appendChild(tableElement);

            _parent?.appendChild(_container);
        }
    }
}
