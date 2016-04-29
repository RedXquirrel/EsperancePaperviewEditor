using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Ui.Helpers;
using Paperview.Common.Ui.Interfaces;
using Paperview.Common.Ui.Models;
using Paperview.Interfaces;

namespace Paperview.Common.Ui
{
    public class LabelPane : IHtmlElement
    {
        // Data
        private Idiom _idiom;
        private string _text;

        // UI
        private readonly HTMLElement _parent;
        private HTMLElement _container;

        // attribute values
        private const string StandardLabelClassKey = "standardLabel";

        // misc
        private string _nbspaceKey = "&nbsp;";

        /// <summary>
        /// The control is only available if the parent that 
        /// it becomes a child of, wasn't passed in.
        /// </summary>
        public HTMLElement Container => _parent == null ? _container : null;

        private TextCase _textCase;
        /// <summary>
        /// TextCase - an enumeration of the cases that text can be displayed, Normal ((default) text as input), Upper (uppercase text), and Lower (lowercase text).
        /// </summary>
        public TextCase TextCase
        {
            get { return _textCase; }
            set
            {
                _textCase = value;
                Initialise(!string.IsNullOrEmpty(_text) ? _text : _nbspaceKey, _idiom);
            }
        }

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                Initialise(!string.IsNullOrEmpty(_text) ? _text : _nbspaceKey, _idiom);
            }
        }

        public LabelPane(Idiom idiom)
        {
            _idiom = idiom;
            Initialise(string.Empty, idiom);
        }

        public LabelPane(string text, Idiom idiom)
        {
            _idiom = idiom;
            Initialise(text, idiom);
        }

        public LabelPane(HTMLElement parent, Idiom idiom)
        {
            _parent = parent;
            _idiom = idiom;
            Initialise(string.Empty, idiom);
        }

        public LabelPane(HTMLElement parent, string text, Idiom idiom)
        {
            _parent = parent;
            _idiom = idiom;
            Initialise(text, idiom);
        }

        private void Initialise(string text, Idiom idiom)
        {
            _text = text;

            if (_container == null)
            {
                _container = Hx.CreateDivElement();
            }
            else
            {
                _container.InnerHtml(string.Empty);
            }

            switch (idiom)
            {
                case Idiom.Phone:
                    Create(idiom);
                    break;
                case Idiom.Tablet:
                    Create(idiom);
                    break;
                case Idiom.Desktop:
                    Create(idiom);
                    break;
                case Idiom.Unsupported:
                    Create(idiom);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(idiom), idiom, null);
            }
        }

        private void Create(Idiom idiom)
        {
            _container.AppendChild(Hx.CreateDivElement().InnerHtml(CasedText()).SetAttribute(Hx.ClassAttKey, StandardLabelClassKey.AppendIdiomString(idiom)));

            _parent?.appendChild(_container);
        }

        private string CasedText()
        {
            switch (_textCase)
            {
                case TextCase.Normal:
                    return _text;
                case TextCase.Upper:
                    return _text.ToUpper();
                case TextCase.Lower:
                    return _text.ToLower();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
