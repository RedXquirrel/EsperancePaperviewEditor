using DuoCode.Dom;
using Paperview.Interfaces;

namespace Paperview.Common.Ui.Helpers
{
    /// <summary>
    /// Hx is short for Html Extensibility
    /// </summary>
    public static class Hx
    {

        #region Tag Keys
        // tags
        // https://www.w3.org/TR/html-markup/elements.html

        public static string ATagKey = "a";
        public static string AbbrTagKey = "abbr";
        public static string AddressTagKey = "address";
        public static string AreaTagKey = "area";
        public static string ArticleTagKey = "article";
        public static string AsideTagKey = "aside";
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
        public static string SectionTagKey = "section";
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
        #endregion

        #region Attribute Keys
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

        // Supernumary attributes
        public static string ValueAttKey = "value";

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
        #endregion

        #region Create Html5 Element methods
        // Every Html tag that is declared by WC3 is here, 
        // vis-a-vis https://www.w3.org/TR/html-markup/elements.html
        // Each function's name is in the format Create{TagName}Element, 
        // where Tagname starts in uppercase but follows in lowercase.

        public static HTMLElement CreateAElement()
        {
            return GetTag(ATagKey);
        }

        public static HTMLElement CreateAbbrElement()
        {
            return GetTag(AbbrTagKey);
        }

        public static HTMLElement CreateAddressElement()
        {
            return GetTag(AddressTagKey);
        }

        public static HTMLElement CreateAreaElement()
        {
            return GetTag(AreaTagKey);
        }

        public static HTMLElement CreateArticleElement()
        {
            return GetTag(ArticleTagKey);
        }

        public static HTMLElement CreateAsideElement()
        {
            return GetTag(AsideTagKey);
        }

        public static HTMLElement CreateAudioElement()
        {
            return GetTag(AudioTagKey);
        }

        public static HTMLElement CreateBElement()
        {
            return GetTag(BTagKey);
        }

        public static HTMLElement CreateBaseElement()
        {
            return GetTag(BaseTagKey);
        }

        public static HTMLElement CreateBdiElement()
        {
            return GetTag(BdiTagKey);
        }

        public static HTMLElement CreateBdoElement()
        {
            return GetTag(BdoTagKey);
        }

        public static HTMLElement CreateBlockquoteElement()
        {
            return GetTag(BlockquoteTagKey);
        }

        public static HTMLElement CreateBodyElement()
        {
            return GetTag(BodyTagKey);
        }

        public static HTMLElement CreateBrElement()
        {
            return GetTag(BrTagKey);
        }

        public static HTMLElement CreateButtonElement()
        {
            return GetTag(ButtonTagKey);
        }

        public static HTMLElement CreateCanvasElement()
        {
            return GetTag(CanvasTagKey);
        }

        public static HTMLElement CreateCaptionElement()
        {
            return GetTag(CaptionTagKey);
        }

        public static HTMLElement CreateCiteElement()
        {
            return GetTag(CiteTagKey);
        }

        public static HTMLElement CreateCodeElement()
        {
            return GetTag(CodeTagKey);
        }

        public static HTMLElement CreateColElement()
        {
            return GetTag(ColTagKey);
        }

        public static HTMLElement CreateColgroupElement()
        {
            return GetTag(ColgroupTagKey);
        }

        public static HTMLElement CreateCommandElement()
        {
            return GetTag(CommandTagKey);
        }

        public static HTMLElement CreateDatalistElement()
        {
            return GetTag(DatalistTagKey);
        }

        public static HTMLElement CreateDdElement()
        {
            return GetTag(DdTagKey);
        }

        public static HTMLElement CreateDelElement()
        {
            return GetTag(DelTagKey);
        }

        public static HTMLElement CreateDetailsElement()
        {
            return GetTag(DetailsTagKey);
        }

        public static HTMLElement CreateDfnElement()
        {
            return GetTag(DfnTagKey);
        }

        public static HTMLElement CreateDivElement()
        {
            return GetTag(DivTagKey);
        }

        public static HTMLElement CreateDlElement()
        {
            return GetTag(DlTagKey);
        }

        public static HTMLElement CreateDtElement()
        {
            return GetTag(DtTagList);
        }

        public static HTMLElement CreateEmElement()
        {
            return GetTag(EmTagKey);
        }

        public static HTMLElement CreateEmbedElement()
        {
            return GetTag(EmbedTagKey);
        }

        public static HTMLElement CreateFieldsetElement()
        {
            return GetTag(FieldsetTagKey);
        }

        public static HTMLElement CreateFigcaptionElement()
        {
            return GetTag(FigcaptionTagKey);
        }

        public static HTMLElement CreateFigureElement()
        {
            return GetTag(FigureTagKey);
        }

        public static HTMLElement CreateFooterElement()
        {
            return GetTag(FooterTagKey);
        }

        public static HTMLElement CreateFormElement()
        {
            return GetTag(FormTagKey);
        }

        public static HTMLElement CreateH1Element()
        {
            return GetTag(H1TagKey);
        }

        public static HTMLElement CreateH2Element()
        {
            return GetTag(H2TagKey);
        }

        public static HTMLElement CreateH3Element()
        {
            return GetTag(H3TagKey);
        }

        public static HTMLElement CreateH4Element()
        {
            return GetTag(H4TagKey);
        }

        public static HTMLElement CreateH5Element()
        {
            return GetTag(H5TagKey);
        }

        public static HTMLElement CreateH6Element()
        {
            return GetTag(H6TagKey);
        }

        public static HTMLElement CreateHeadElement()
        {
            return GetTag(HeadTagKey);
        }

        public static HTMLElement CreateHeaderElement()
        {
            return GetTag(HeaderTagKey);
        }

        public static HTMLElement CreateHgroupElement()
        {
            return GetTag(HgroupTagKey);
        }

        public static HTMLElement CreateHrElement()
        {
            return GetTag(HrTagKey);
        }

        public static HTMLElement CreateHtmlElement()
        {
            return GetTag(HtmlTagKey);
        }

        public static HTMLElement CreateIElement()
        {
            return GetTag(ITagKey);
        }

        public static HTMLElement CreateIframeElement()
        {
            return GetTag(IframeTagKey);
        }

        public static HTMLElement CreateImgElement()
        {
            return GetTag(ImgTagKey);
        }

        public static HTMLElement CreateInputElement()
        {
            return GetTag(InputTagKey);
        }

        public static HTMLElement CreateInsElement()
        {
            return GetTag(InsTagKey);
        }

        public static HTMLElement CreateKbdElement()
        {
            return GetTag(KbdTagKey);
        }

        public static HTMLElement CreateKeygenElement()
        {
            return GetTag(KeygenTagKey);
        }

        public static HTMLElement CreateLabelElement()
        {
            return GetTag(LabelTagKey);
        }

        public static HTMLElement CreateLegendElement()
        {
            return GetTag(LegendTagKey);
        }

        public static HTMLElement CreateLiElement()
        {
            return GetTag(LiTagKey);
        }

        public static HTMLElement CreateLinkElement()
        {
            return GetTag(LinkTagKey);
        }

        public static HTMLElement CreateMapElement()
        {
            return GetTag(MapTagKey);
        }

        public static HTMLElement CreateMarkElement()
        {
            return GetTag(MarkTagKey);
        }

        public static HTMLElement CreateMenuElement()
        {
            return GetTag(MenuTagKey);
        }

        public static HTMLElement CreateMetaElement()
        {
            return GetTag(MetaTagKey);
        }

        public static HTMLElement CreateMeterElement()
        {
            return GetTag(MeterTagKey);
        }

        public static HTMLElement CreateNavElement()
        {
            return GetTag(NavTagKey);
        }

        public static HTMLElement CreateNoscriptElement()
        {
            return GetTag(NoscriptTagKey);
        }

        public static HTMLElement CreateObjectElement()
        {
            return GetTag(ObjectTagKey);
        }

        public static HTMLElement CreateOlElement()
        {
            return GetTag(OlTagKey);
        }

        public static HTMLElement CreateOptgroupElement()
        {
            return GetTag(OptgroupTagKey);
        }

        public static HTMLElement CreateOptionElement()
        {
            return GetTag(OptionTagKey);
        }

        public static HTMLElement CreateOutputElement()
        {
            return GetTag(OutputTagKey);
        }

        public static HTMLElement CreatePElement()
        {
            return GetTag(PTagKey);
        }

        public static HTMLElement CreateParamElement()
        {
            return GetTag(ParamTagKey);
        }

        public static HTMLElement CreatePreElement()
        {
            return GetTag(PreTagKey);
        }

        public static HTMLElement CreateProgressElement()
        {
            return GetTag(ProgressTagKey);
        }

        public static HTMLElement CreateQElement()
        {
            return GetTag(QTagKey);
        }

        public static HTMLElement CreateRpElement()
        {
            return GetTag(RpTagKey);
        }

        public static HTMLElement CreateRtElement()
        {
            return GetTag(RtTagKey);
        }

        public static HTMLElement CreateRubyElement()
        {
            return GetTag(RubyTagKey);
        }

        public static HTMLElement CreateSElement()
        {
            return GetTag(STagKey);
        }

        public static HTMLElement CreateSampElement()
        {
            return GetTag(SampTagKey);
        }

        public static HTMLElement CreateScriptElement()
        {
            return GetTag(ScriptTagKey);
        }

        public static HTMLElement CreateSectionElement()
        {
            return GetTag(SectionTagKey);
        }

        public static HTMLElement CreateSelectElement()
        {
            return GetTag(SelectTagKey);
        }

        public static HTMLElement CreateSmallElement()
        {
            return GetTag(SmallTagKey);
        }

        public static HTMLElement CreateSourceElement()
        {
            return GetTag(SourceTagKey);
        }

        public static HTMLElement CreateSpanElement()
        {
            return GetTag(SpanTagKey);
        }

        public static HTMLElement CreateStrongElement()
        {
            return GetTag(StrongTagKey);
        }

        public static HTMLElement CreateStyleElement()
        {
            return GetTag(StyleTagKey);
        }

        public static HTMLElement CreateSubElement()
        {
            return GetTag(SubTagKey);
        }

        public static HTMLElement CreateSummaryElement()
        {
            return GetTag(SummaryTagKey);
        }

        public static HTMLElement CreateSupElement()
        {
            return GetTag(SupTagKey);
        }

        public static HTMLElement CreateTableElement()
        {
            return GetTag(TableTagKey);
        }

        public static HTMLElement CreateTbodyElement()
        {
            return GetTag(TbodyTagKey);
        }

        public static HTMLElement CreateTdElement()
        {
            return GetTag(TdTagKey);
        }

        public static HTMLElement CreateTextareaElement()
        {
            return GetTag(TextareaTagKey);
        }

        public static HTMLElement CreateTfootElement()
        {
            return GetTag(TfootTagKey);
        }

        public static HTMLElement CreateThElement()
        {
            return GetTag(ThTagKey);
        }

        public static HTMLElement CreateTheadElement()
        {
            return GetTag(TheadTagKey);
        }

        public static HTMLElement CreateTimeElement()
        {
            return GetTag(TimeTagKey);
        }

        public static HTMLElement CreateTitleElement()
        {
            return GetTag(TitleTagKey);
        }

        public static HTMLElement CreateTrElement()
        {
            return GetTag(TrTagKey);
        }

        public static HTMLElement CreateTrackElement()
        {
            return GetTag(TrackTagkey);
        }

        public static HTMLElement CreateUElement()
        {
            return GetTag(UTagKey);
        }

        public static HTMLElement CreateUlElement()
        {
            return GetTag(UlTagKey);
        }

        public static HTMLElement CreateVarElement()
        {
            return GetTag(VarTagKey);
        }

        public static HTMLElement CreateVideoElement()
        {
            return GetTag(VideoTagKey);
        }

        public static HTMLElement CreateWbrElement()
        {
            return GetTag(WbrTagKey);
        }
        #endregion

        public static HTMLElement CreateContainerControl()
        {
            return Global.document.createElement(Hx.DivTagKey);
        }

        #region Extension methods

        public static string AppendIdiomString(this string classKey, Idiom idiom)
        {
            return $"{classKey}{idiom.ToString()}";
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
        #endregion

        #region Private helper functions
        private static HTMLElement GetTag(string key)
        {
            return Global.document.createElement(key);
        }
        #endregion
    }
}