using System;
using System.Collections.Generic;
using DuoCode.Dom;
using Paperview.Common.Helpers;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class DropDownAuthorsListPane : IHtmlElement
    {
        // Data
        private List<Author> _authors;
        private int _selectedAuthorIndex;
        private Idiom _idiom;

        // action
        private Action<int> _selectedAuthorAction;

        // UI
        private readonly HTMLElement _parent;
        private HTMLElement _container;
        private HTMLSelectElement _select;

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        public DropDownAuthorsListPane(List<Author> authors, Action<int> selectedAction, Idiom idiom)
        {
            Initialise(authors, selectedAction, idiom);
        }

        public DropDownAuthorsListPane(HTMLElement parent, List<Author> authors, Action<int> selectedAction, Idiom idiom)
        {
            _parent = parent;
            Initialise(authors, selectedAction, idiom);
        }

        private void Initialise(List<Author> authors, Action<int> selectedAction, Idiom idiom)
        {
            // store data
            _authors = authors;
            _idiom = idiom;
            // store action
            _selectedAuthorAction = selectedAction;
            // create container
            _container = Hx.CreateContainerControl();

            // switch on idiom
            switch (idiom)
            {
                case Idiom.Phone:
                    CreateSelect(idiom);
                    break;
                case Idiom.Tablet:
                    CreateSelect(idiom);
                    break;
                case Idiom.Desktop:
                    CreateSelect(idiom);
                    break;
                case Idiom.Unsupported:
                    CreateSelect(idiom);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(idiom), idiom, null);
            }
        }

        private void CreateSelect(Idiom idiom)
        {
            _select = (HTMLSelectElement)Hx.CreateSelectElement().SetAttribute(Hx.ClassAttKey, AppStyles.StandardSelectClassKey.AppendIdiomString(idiom));

            _select.onchange = onchangeevent =>
            {
                System.Console.WriteLine($"Selected Index: {_select.selectedIndex}");

                _selectedAuthorIndex = _select.selectedIndex - 1;

                if (_selectedAuthorIndex >= 0)
                {
                    System.Console.WriteLine($"Selected Author: {_authors[_selectedAuthorIndex].Name}");
                }

                _selectedAuthorAction.invoke(_select.selectedIndex - 1);

                return 0;
            };

            _select.AppendChild(Hx.CreateOptionElement().SetAttribute(Hx.ValueAttKey, "-1").SetAttribute(Hx.ClassAttKey, AppStyles.StandardOptionClassKey.AppendIdiomString(idiom)).InnerHtml(UiResources.AuthorPleaseSelectText));

            foreach (var author in _authors)
            {
                _select.AppendChild(Hx.CreateOptionElement().SetAttribute(Hx.ValueAttKey, author.Id).SetAttribute(Hx.ClassAttKey, AppStyles.StandardOptionClassKey.AppendIdiomString(idiom)).InnerHtml(author.Name));
            }

            _container.AppendChild(_select);

            _parent?.appendChild(_container);
        }
    }
}