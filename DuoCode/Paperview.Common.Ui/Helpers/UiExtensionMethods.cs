using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Ui.Interfaces;

namespace Paperview.Common.Ui.Helpers
{
    public static class UiX
    {
        // tags
        public static string DivTagKey = "div";
        public static string TableTagKey = "table";
        public static string TableRowKey = "tr";
        public static string TableCellKey = "td";

        // attribute names
        public static string ClassAttributeKey = "class";

        public static string AssertLocale(this Dictionary<string, string> localeDictionary, string locale, string defaultLocale)
        {
            // Cascade keys from specified locale, to default locale, then at worst return string.empty.
            return localeDictionary.ContainsKey(locale) ? localeDictionary[locale] : (localeDictionary.ContainsKey(defaultLocale) ? localeDictionary[defaultLocale] : string.Empty); 
        }

        public static HTMLElement GetContainer(this IHtmlElement control)
        {
            return control.Container;
        }

        public static HTMLElement AppendChild(this HTMLElement parent, HTMLElement child)
        {
            parent.appendChild(child);

            return parent;
        }

        public static HTMLElement AppendChild(this HTMLElement parent, HTMLElement child, string innerHTML, string styleKey)
        {
            child.innerHTML = innerHTML;
            child.setAttribute("class", styleKey);
            parent.appendChild(child);

            return parent;
        }

        public static HTMLElement CreateTableElement()
        {
            return Global.document.createElement(TableTagKey);
        }

        public static HTMLElement CreateTrElement()
        {
            return Global.document.createElement(TableRowKey);
        }

        public static HTMLElement CreateTdElement()
        {
            return Global.document.createElement(TableCellKey);
        }

        public static HTMLElement SetAttribute(this HTMLElement element, string name, string value)
        {
            element.setAttribute(name,value);
            return element;
        }


    }
}
