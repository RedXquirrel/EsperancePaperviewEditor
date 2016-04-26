using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuoCode.Dom;
using Paperview.Common.Ui.Interfaces;

namespace Paperview.Common.Ui.Helpers
{
    public static class UiExtensionMethods
    {
        public static string AssertLocale(this Dictionary<string, string> localeDictionary, string locale, string defaultLocale)
        {
            // Cascade keys from specified locale, to default locale, then at worst return string.empty.
            return localeDictionary.ContainsKey(locale) ? localeDictionary[locale] : (localeDictionary.ContainsKey(defaultLocale) ? localeDictionary[defaultLocale] : string.Empty); 
        }

        public static HTMLElement GetContainer(this IHtmlElement control)
        {
            return control.Container;
        }
    }
}
