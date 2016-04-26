using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class DocumentTypePane : IHtmlElement
    {
        // Data
        private Document _document;
        private string _locale;

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

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        public DocumentTypePane(Document document, Idiom idiom, string locale)
        {
            Initialise(document, idiom, locale);
        }

        public DocumentTypePane(HTMLElement parent, Document document, Idiom idiom, string locale)
        {
            _parent = parent;
            Initialise(document, idiom, locale);
        }

        private void Initialise(Document mfDocument, Idiom idiom, string locale)
        {
            _document = mfDocument;
            _container = Global.document.createElement(DivTagKey);
            _locale = locale;

            switch (idiom)
            {
                case Idiom.Phone:
                    CreateStack();
                    break;
                case Idiom.Tablet:
                    CreateTable();
                    break;
                case Idiom.Desktop:
                    CreateTable();
                    break;
                case Idiom.Unsupported:
                    CreateTable();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(idiom), idiom, null);
            }
        }

        private void CreateStack()
        {
            var idLabelElement = Global.document.createElement(DivTagKey);
            idLabelElement.innerHTML = UiResources.DocumentTypeIdLabel;
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _container.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(DivTagKey);
            idValueElement.innerHTML = _document.MicroformatId;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _container.appendChild(idValueElement);

            var nameLabelElement = Global.document.createElement(DivTagKey);
            nameLabelElement.innerHTML = UiResources.DocumentTypeNameLabel;
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _container.appendChild(nameLabelElement);

            var nameValueElement = Global.document.createElement(DivTagKey);
            nameValueElement.innerHTML = _document.MicroformatName.AssertLocale(_locale, _document.LanguageDefault);
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _container.appendChild(nameValueElement);

            var descriptionLabelElement = Global.document.createElement(DivTagKey);
            descriptionLabelElement.innerHTML = UiResources.DocumentTypeDescriptionLabel;
            descriptionLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _container.appendChild(descriptionLabelElement);

            var descriptionValueElement = Global.document.createElement(DivTagKey);
            descriptionValueElement.innerHTML = _document.MicroformatDescription.AssertLocale(_locale, _document.LanguageDefault);
            descriptionValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _container.appendChild(descriptionValueElement);

            _parent?.appendChild(_container);
        }

        private void CreateTable()
        {
            var tableElement = Global.document.createElement(TableTagKey);
            tableElement.setAttribute(ClassAttributeKey, TableClassKey);

            var row1Element = Global.document.createElement(TableRowKey);

            var idLabelElement = Global.document.createElement(DivTagKey);
            idLabelElement.innerHTML = UiResources.DocumentTypeIdLabel;
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row1Element.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(DivTagKey);
            idValueElement.innerHTML = _document.MicroformatId;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row1Element.appendChild(idValueElement);

            var row2Element = Global.document.createElement(TableRowKey);

            var nameLabelElement = Global.document.createElement(DivTagKey);
            nameLabelElement.innerHTML = UiResources.DocumentTypeNameLabel;
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row2Element.appendChild(nameLabelElement);

            var nameValueElement = Global.document.createElement(DivTagKey);
            nameValueElement.innerHTML = _document.MicroformatName.AssertLocale(_locale, _document.LanguageDefault);
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row2Element.appendChild(nameValueElement);

            var row3Element = Global.document.createElement(TableRowKey);

            var descriptionLabelElement = Global.document.createElement(DivTagKey);
            descriptionLabelElement.innerHTML = UiResources.DocumentTypeDescriptionLabel;
            descriptionLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row3Element.appendChild(descriptionLabelElement);

            var descriptionValueElement = Global.document.createElement(DivTagKey);
            descriptionValueElement.innerHTML = _document.MicroformatDescription.AssertLocale(_locale, _document.LanguageDefault);
            descriptionValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row3Element.appendChild(descriptionValueElement);

            tableElement.appendChild(row1Element);
            tableElement.appendChild(row2Element);
            tableElement.appendChild(row3Element);

            _container.appendChild(tableElement);

            _parent?.appendChild(_container);
        }
    }
}
