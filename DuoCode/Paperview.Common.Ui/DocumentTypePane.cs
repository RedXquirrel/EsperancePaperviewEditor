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
            _container
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, NameCellClassKey)
                            .InnerHtml(UiResources.DocumentTypeIdLabel))
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, ValueCellClassKey)
                            .InnerHtml(_document.MicroformatId))
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, NameCellClassKey)
                            .InnerHtml(UiResources.DocumentTypeNameLabel))
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, ValueCellClassKey)
                            .InnerHtml(_document.MicroformatName.AssertLocale(_locale, _document.LanguageDefault)))
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, NameCellClassKey)
                            .InnerHtml(UiResources.DocumentTypeDescriptionLabel))
            .AppendChild(Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttributeKey, ValueCellClassKey)
                            .InnerHtml(_document.MicroformatDescription.AssertLocale(_locale, _document.LanguageDefault)));

            _parent?.appendChild(_container);
        }

        private void CreateTable()
        {
            _container.AppendChild(Hx.CreateTableElement()
                                        .SetAttribute(Hx.ClassAttributeKey, TableClassKey)
                                        .AppendChild(Hx.CreateTrElement()
                                                        .AppendChild(Hx.CreateTdElement(), UiResources.DocumentTypeIdLabel, NameCellClassKey)
                                                        .AppendChild(Hx.CreateTdElement(), _document.MicroformatId, ValueCellClassKey))
                                        .AppendChild(Hx.CreateTrElement()
                                                        .AppendChild(Hx.CreateTdElement(), UiResources.DocumentTypeNameLabel, NameCellClassKey)
                                                        .AppendChild(Hx.CreateTdElement(), _document.MicroformatName.AssertLocale(_locale, _document.LanguageDefault), ValueCellClassKey))
                                        .AppendChild(Hx.CreateTrElement()
                                                .AppendChild(Hx.CreateTdElement(), UiResources.DocumentTypeDescriptionLabel, NameCellClassKey)
                                                .AppendChild(Hx.CreateTdElement(), _document.MicroformatDescription.AssertLocale(_locale, _document.LanguageDefault), ValueCellClassKey))
            );
            
            _parent?.appendChild(_container);
        }
    }
}
