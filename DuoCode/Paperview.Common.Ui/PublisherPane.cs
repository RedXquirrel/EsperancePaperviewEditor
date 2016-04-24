using System;
using DuoCode.Dom;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class PublisherPane
    {
        // Data
        private readonly Publisher _publisher;

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
        private const string TableKey = "standardNameValuePairTable";
        private const string NameCellClassKey = "standardNamePairCell";
        private const string ValueCellClassKey = "standardValuePairCell";


        public PublisherPane(HTMLElement root, Publisher publisher, Idiom idiom)
        {
            _root = root;
            _publisher = publisher;

            switch(idiom)
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
            idLabelElement.innerHTML = UiResources.PublisherIdLabel;
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(DivTagKey);
            idValueElement.innerHTML = _publisher.Id;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(idValueElement);

            var nameLabelElement = Global.document.createElement(DivTagKey);
            nameLabelElement.innerHTML = UiResources.PublisherNameLabel;
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(nameLabelElement);

            var nameValueElement = Global.document.createElement(DivTagKey);
            nameValueElement.innerHTML = _publisher.Name;
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(nameValueElement);

            var emailAddressLabelElement = Global.document.createElement(DivTagKey);
            emailAddressLabelElement.innerHTML = UiResources.PublisherEmailAddressLabel;
            emailAddressLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(emailAddressLabelElement);

            var emailAddressValueElement = Global.document.createElement(DivTagKey);
            emailAddressValueElement.innerHTML = _publisher.Email;
            emailAddressValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(emailAddressValueElement);

            var urlLabelElement = Global.document.createElement(DivTagKey);
            urlLabelElement.innerHTML = UiResources.PublisherWebAddressLabel;
            urlLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            _root.appendChild(urlLabelElement);

            var urlValueElement = Global.document.createElement(DivTagKey);
            urlValueElement.innerHTML = _publisher.Url;
            urlValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            _root.appendChild(urlValueElement);
        }

        private void CreateTable()
        {
            var tableElement = Global.document.createElement(TableTagKey);
            tableElement.setAttribute(ClassAttributeKey, TableKey);

            var row1Element = Global.document.createElement(TableRowKey);

            var idLabelElement = Global.document.createElement(TableCellKey);
            idLabelElement.innerHTML = "Id";
            idLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row1Element.appendChild(idLabelElement);

            var idValueElement = Global.document.createElement(TableCellKey);
            idValueElement.innerHTML = _publisher.Id;
            idValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row1Element.appendChild(idValueElement);

            var row2Element = Global.document.createElement(TableRowKey);

            var nameLabelElement = Global.document.createElement(TableCellKey);
            nameLabelElement.innerHTML = "Name";
            nameLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row2Element.appendChild((nameLabelElement));

            var nameValueElement = Global.document.createElement(TableCellKey);
            nameValueElement.innerHTML = _publisher.Name;
            nameValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row2Element.appendChild(nameValueElement);

            var row3Element = Global.document.createElement(TableRowKey);

            var emailLabelElement = Global.document.createElement(TableCellKey);
            emailLabelElement.innerHTML = "Email";
            emailLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row3Element.appendChild(emailLabelElement);

            var emailValueElement = Global.document.createElement(TableCellKey);
            emailValueElement.innerHTML = _publisher.Email;
            emailValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row3Element.appendChild(emailValueElement);

            var row4Element = Global.document.createElement(TableRowKey);

            var urlLabelElement = Global.document.createElement(TableCellKey);
            urlLabelElement.innerHTML = "Web Address";
            urlLabelElement.setAttribute(ClassAttributeKey, NameCellClassKey);
            row4Element.appendChild((urlLabelElement));

            var urlValueElement = Global.document.createElement(TableCellKey);
            urlValueElement.innerHTML = _publisher.Url;
            urlValueElement.setAttribute(ClassAttributeKey, ValueCellClassKey);
            row4Element.appendChild(urlValueElement);

            tableElement.appendChild(row1Element);
            tableElement.appendChild(row2Element);
            tableElement.appendChild(row3Element);
            tableElement.appendChild(row4Element);

            _root.appendChild(tableElement);
        }
    }
}
