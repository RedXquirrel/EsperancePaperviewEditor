using System;
using DuoCode.Dom;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Localisation;

namespace Paperview.Common.Ui
{
    public class Panel : IHtmlElement
    {
        // UI
        private readonly HTMLElement _parent;
        private HTMLElement _container;

        // tags
        private const string DivTagKey = "div";

        // attribute names
        private const string ClassAttributeKey = "class";

        // attribute values
        private const string ContainerCellClassKey = "standardPanelContainerCell";
        private const string TitleCellClassKey = "standardPanelTitleCell";
        private const string ContentCellClassKey = "standardPanelContentCell";

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        /// <summary>
        /// Creates a Panel that can later be made the child of a parent
        /// by accessing the Panel's Container property. The Panel contains
        /// the content passed in, and bears the title passed in.
        /// </summary>
        /// <param name="content">Content of the Panel.</param>
        /// <param name="panelTitle">Title of the Panel.</param>
        public Panel(HTMLElement content, string panelTitle)
        {
            Initialise(content, panelTitle);
        }

        /// <summary>
        /// Creates a Panel appended to the parent element passed in, 
        /// containing content passed in, and bearing the title 
        /// passed in.
        /// </summary>
        /// <param name="parent">Element to append this Panel.</param>
        /// <param name="content">Content of the Panel.</param>
        /// <param name="panelTitle">Title of the Panel.</param>
        public Panel(HTMLElement parent, HTMLElement content, string panelTitle)
        {
            _parent = parent;

            Initialise(content, panelTitle);
        }

        private void Initialise(HTMLElement content, string panelTitle)
        {
            _container =  Hx.CreateDivElement()
                            .SetAttribute(Hx.ClassAttKey, ContainerCellClassKey)
                            .AppendChild(Hx.CreateDivElement()
                                           .SetAttribute(Hx.ClassAttKey, TitleCellClassKey)
                                           .InnerHtml(panelTitle))
                            .AppendChild(Hx.CreateDivElement()
                                           .SetAttribute(Hx.ClassAttKey, ContentCellClassKey)
                                           .AppendChild(content));

            _parent?.appendChild(_container);
        }
    }
}