using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class DocumentTypePane
    {
        // Data
        private readonly Document _document;
        private readonly string _locale;

        // UI
        private readonly HTMLElement _root;

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


        public DocumentTypePane(HTMLElement root, Document document, Idiom idiom, string locale)
        {
            _root = root;
            _document = document;
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

        private void CreateTable()
        {
            throw new NotImplementedException();
        }

        private void CreateStack()
        {
            var idLabelElement = Global.document.createElement(DivTagKey);
            idLabelElement.innerHTML = UiResources.DocumentTypeIdLabel;
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(DivTagKey);
            idValueElement.innerHTML = _document.MicroformatId;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(idValueElement);

            var nameLabelElement = Global.document.createElement(DivTagKey);
            nameLabelElement.innerHTML = UiResources.DocumentTypeNameLabel;
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(nameLabelElement);

            var nameValueElement = Global.document.createElement(DivTagKey);
            nameValueElement.innerHTML = _document.MicroformatName.AssertLocale(_locale, _document.LanguageDefault);
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(nameValueElement);

            var descriptionLabelElement = Global.document.createElement(DivTagKey);
            descriptionLabelElement.innerHTML = UiResources.DocumentTypeDescriptionLabel;
            descriptionLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(descriptionLabelElement);

            var descriptionValueElement = Global.document.createElement(DivTagKey);
            descriptionValueElement.innerHTML = _document.MicroformatDescription.AssertLocale(_locale, _document.LanguageDefault);
            descriptionValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(descriptionValueElement);
        }
    }
}
