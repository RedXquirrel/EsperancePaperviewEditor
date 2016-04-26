using DuoCode.Dom;

namespace Paperview.Common.Ui.Helpers
{
    /// <summary>
    /// Hx is short for Html Extensibility
    /// </summary>
    public static class Hx
    {
        // tags
        public static string DivTagKey = "div";
        public static string TableTagKey = "table";
        public static string TableRowKey = "tr";
        public static string TableCellKey = "td";

        // attribute names
        public static string ClassAttributeKey = "class";

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

        public static HTMLElement CreateDivElement()
        {
            return Global.document.createElement(DivTagKey);
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

        public static HTMLElement InnerHtml(this HTMLElement element, string innerHtml)
        {
            element.innerHTML = innerHtml;

            return element;
        }
    }
}