using System;
using System.Collections.Generic;
using System.Text;
using Chat.Esperance.Paperview.iOS.Renderers;
using Chat.Esperance.Paperview.Views;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BaseUrlWebView), typeof(BaseUrlWebViewRenderer))]

namespace Chat.Esperance.Paperview.iOS.Renderers
{
    public class BaseUrlWebViewRenderer : WebViewRenderer
    {
        public override void LoadHtmlString(string s, NSUrl baseUrl)
        {
            baseUrl = new NSUrl(NSBundle.MainBundle.BundlePath, true);
            base.LoadHtmlString(s, baseUrl);
        }
    }
}
