using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Helpers;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Localisation;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class DropDownPublishersListPane : IHtmlElement
    {
        // Data
        private List<Publisher> _publishers;
        private int _selectedPublisherIndex;
        private Idiom _idiom;

        // action
        private Action<int> _selectedPublisherAction;

        // UI
        private readonly HTMLElement _parent;
        private HTMLElement _container;
        private HTMLSelectElement _select;

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        public DropDownPublishersListPane(List<Publisher> publishers, Action<int> selectedAction, Idiom idiom)
        {
            Initialise(publishers, selectedAction, idiom);
        }

        public DropDownPublishersListPane(HTMLElement parent, List<Publisher> publishers, Action<int> selectedAction, Idiom idiom)
        {
            _parent = parent;
            Initialise(publishers, selectedAction, idiom);
        }

        private void Initialise(List<Publisher> publishers, Action<int> selectedAction, Idiom idiom)
        {
            // store data
            _publishers = publishers;
            _idiom = idiom;
            // store action
            _selectedPublisherAction = selectedAction;
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

                _selectedPublisherIndex = _select.selectedIndex - 1;

                if (_selectedPublisherIndex >= 0)
                {
                    System.Console.WriteLine($"Selected Publisher: {_publishers[_selectedPublisherIndex].Name}");
                }

                System.Console.WriteLine($"Selected Publisher Index: {_select.selectedIndex - 1}");

                _selectedPublisherAction.invoke(_select.selectedIndex-1);

                return 0;
            };


            _select.AppendChild(Hx.CreateOptionElement().SetAttribute(Hx.ValueAttKey, "-1").SetAttribute(Hx.ClassAttKey, AppStyles.StandardOptionClassKey.AppendIdiomString(idiom)).InnerHtml(UiResources.PublisherPleaseSelectText));

            foreach (var publisher in _publishers)
            {
                _select.AppendChild(Hx.CreateOptionElement().SetAttribute(Hx.ValueAttKey, publisher.Id).SetAttribute(Hx.ClassAttKey,AppStyles.StandardOptionClassKey.AppendIdiomString(idiom)).InnerHtml(publisher.Name));
            }

            _container.AppendChild(_select);

            _parent?.appendChild(_container);
        }
    }
}
