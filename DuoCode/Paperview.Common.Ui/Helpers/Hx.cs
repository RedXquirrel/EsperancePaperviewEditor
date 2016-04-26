using DuoCode.Dom;

namespace Paperview.Common.Ui.Helpers
{
    /// <summary>
    /// Hx is short for Html Extensibility
    /// </summary>
    public static class Hx
    {
        // tags
        // https://www.w3.org/TR/html-markup/elements.html

        public static string ATagKey = "a";
        public static string AbbrTagKey = "abbr";
        public static string AddressTagKey = "address";
        public static string AreaTagKey = "area";
        public static string ArticleTagKey = "article";
        public static string AsideKey = "aside";
        public static string AudioTagKey = "audio";
        public static string BTagKey = "b";
        public static string BaseTagKey = "base";
        public static string BdiTagKey = "bdi";
        public static string BdoTagKey = "bdo";
        public static string BlockquoteTagKey = "blockquote";
        public static string BodyTagKey = "body";
        public static string BrTagKey = "br";
        public static string ButtonTagKey = "button";
        public static string CanvasTagKey = "canvas";
        public static string CaptionTagKey = "caption";
        public static string CiteTagKey = "cite";
        public static string CodeTagKey = "code";
        public static string ColTagKey = "col";
        public static string ColgroupTagKey = "colgroup";
        public static string CommandTagKey = "command";
        public static string DatalistTagKey = "datalist";
        public static string DdTagKey = "dd";
        public static string DelTagKey = "del";
        public static string DetailsTagKey = "details";
        public static string DfnTagKey = "dfn";
        public static string DivTagKey = "div";
        public static string DlTagKey = "dl";
        public static string DtTagList = "dt";
        public static string EmTagKey = "em";
        public static string EmbedTagKey = "embed";
        public static string FieldsetTagKey = "fieldset";
        public static string FigcaptionTagKey = "figcaption";
        public static string FigureTagKey = "figure";
        public static string FooterTagKey = "footer";
        public static string FormTagKey = "form";
        public static string H1TagKey = "h1";
        public static string H2TagKey = "h2";
        public static string H3TagKey = "h3";
        public static string H4TagKey = "h4";
        public static string H5TagKey = "h5";
        public static string H6TagKey = "h6";
        public static string HeadTagKey = "head";
        public static string HeaderTagKey = "header";
        public static string HgroupTagKey = "hgroup";
        public static string HrTagKey = "hr";
        public static string HtmlTagKey = "html";
        public static string ITagKey = "i";
        public static string IframeTagKey = "iframe";
        public static string ImgTagKey = "img";
        public static string InputTagKey = "input";
        public static string InsTagKey = "ins";
        public static string KbdTagKey = "kbd";
        public static string KeygenTagKey = "keygen";
        public static string LabelTagKey = "label";
        public static string LegendTagKey = "legend";
        public static string LiTagKey = "li";
        public static string LinkTagKey = "link";
        public static string MapTagKey = "map";
        public static string MarkTagKey = "mark";
        public static string MenuTagKey = "menu";
        public static string MetaTagKey = "meta";
        public static string MeterTagKey = "meter";
        public static string NavTagKey = "nav";
        public static string NoscriptTagKey = "noscript";
        public static string ObjectTagKey = "object";
        public static string OlTagKey = "ol";
        public static string OptgroupTagKey = "optgroup";
        public static string OptionTagKey = "option";
        public static string OutputTagKey = "output";
        public static string PTagKey = "p";
        public static string ParamTagKey = "param";
        public static string PreTagKey = "pre";
        public static string ProgressTagKey = "progress";
        public static string QTagKey = "q";
        public static string RpTagKey = "rp";
        public static string RtTagKey = "rt";
        public static string RubyTagKey = "ruby";
        public static string STagKey = "s";
        public static string SampTagKey = "samp";
        public static string ScriptTagKey = "script";
        public static string SelectionTagKey = "selection";
        public static string SelectTagKey = "select";
        public static string SmallTagKey = "small";
        public static string SourceTagKey = "source";
        public static string SpanTagKey = "span";
        public static string StrongTagKey = "strong";
        public static string StyleTagKey = "style";
        public static string SubTagKey = "sub";
        public static string SummaryTagKey = "summary";
        public static string SupTagKey = "sup";
        public static string TableTagKey = "table";
        public static string TbodyTagKey = "tbody";
        public static string TdTagKey = "td";
        public static string TextareaTagKey = "textarea";
        public static string TfootTagKey = "tfoot";
        public static string ThTagKey = "th";
        public static string TheadTagKey = "thead";
        public static string TimeTagKey = "time";
        public static string TitleTagKey = "title";
        public static string TrTagKey = "tr";
        public static string TrackTagkey = "track";
        public static string UTagKey = "u";
        public static string UlTagKey = "ul";
        public static string VarTagKey = "var";
        public static string VideoTagKey = "video";
        public static string WbrTagKey = "wbr";


        // attribute names
        // https://www.w3.org/TR/html-markup/global-attributes.html#common.attrs.contenteditable

        // Core attributes
        public static string AccesskeyAttKey = "accesskey";
        public static string ClassAttKey = "class";
        public static string ContenteditableAttKey = "contenteditable";
        public static string ContextmenuAttKey = "contextmenu";
        public static string DirAttKey = "dir";
        public static string DraggableAttKey = "draggable";
        public static string DropzoneAttKey = "dropzone";
        public static string HiddenAttKey = "hidden";
        public static string IdAttKey = "id";
        public static string LangAttKey = "lang";
        public static string SpellcheckAttKey = "spellcheck";
        public static string StyleAttKey = "style";
        public static string TabindexAttKey = "tabindex";
        public static string TitleAttKey = "title";
        public static string TranslateAttKey = "translate";

        // Event-handler attributes
        public static string OnabortAttKey = "onabort";
        public static string OnblurAttKey = "onblur";
        public static string OncanplayAttKey = "oncanplay";
        public static string OncanplaythroughAttKey = "oncanplaythrough";
        public static string OnchangeAttKey = "onchange";
        public static string OnclickAttKey = "onclick";
        public static string OncontextmenuAttKey = "oncontextmenu";
        public static string OndblclickAttKey = "ondblclick";
        public static string OndragAttKey = "ondrag";
        public static string OndragendAttKey = "ondragend";
        public static string OndragenterAttKey = "ondragenter";
        public static string OndragleaveAttKey = "ondragleave";
        public static string OndragoverAttKey = "ondragover";
        public static string OndragstartAttKey = "ondragstart";
        public static string OndropAttKey = "ondrop";
        public static string OndurationchangeAttKey = "ondurationchange";
        public static string OnemptiedAttKey = "onemptied";
        public static string OnendedAttKey = "onended";
        public static string OnerrorAttKey = "onerror";
        public static string OnfocusAttyKey = "onfocus";
        public static string OninputAttKey = "oninput";
        public static string OninvalidAttKey = "oninvalid";
        public static string OnkeydownAttKey = "onkeydown";
        public static string OnkeypressAttKey = "onkeypress";
        public static string OnkeyupAttKey = "onkeyup";
        public static string OnloadAttKey = "onload";
        public static string OnloadeddataAttKey = "onloadeddata";
        public static string OnloadedmetatdataAttKey = "onloadedmetadata";
        public static string OnloadStartAttKey = "onloadstart";
        public static string OnmousedownAttKey = "onmousedown";
        public static string OnmousemoveAttKey = "onmousemove";
        public static string OnmouseoutAttKey = "onmouseout";
        public static string OnmouseoverAttKey = "onmouseover";
        public static string OnmouseupAttKey = "onmouseup";
        public static string OnmousewheelAttKey = "onmousewheel";
        public static string OnpauseAttKey = "onpause";
        public static string OnplayAttKey = "onplay";
        public static string OnplayingAttKey = "onplaying";
        public static string OnprogressAttKey = "onprogress";
        public static string OnratechangeAttKey = "onratechange";
        public static string OnreadystatechangeAttKey = "onreadystatechange";
        public static string OnresetAttKey = "onreset";
        public static string OnscrollAttKey = "onscroll";
        public static string OnseekedAttKey = "onseeked";
        public static string OnseekingAttKey = "onseeking";
        public static string OnselectAttKey = "onselect";
        public static string OnshowAttKey = "onshow";
        public static string OnstalledAttKey = "onstalled";
        public static string OnsubmitAttKey = "onsubmit";
        public static string OnsuspendAttKey = "onsuspend";
        public static string OntimeupdateAttKey = "ontimeupdate";
        public static string OnvolumechangeAttKey = "onvolumechange";
        public static string OnwaitingAttKey = "onwaiting";

        // Xml Attributes
        public static string Xml_langAttKey = "xml:lang";
        public static string Xml_spaceAttKey = "xml:space";
        public static string Xml_baseAttKey = "xml:base";




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
            return Global.document.createElement(TrTagKey);
        }

        public static HTMLElement CreateTdElement()
        {
            return Global.document.createElement(TdTagKey);
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