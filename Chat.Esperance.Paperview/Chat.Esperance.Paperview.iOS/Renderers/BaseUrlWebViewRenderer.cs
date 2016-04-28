using System;
using System.Collections.Generic;
using System.Text;
using Chat.Esperance.Paperview.iOS.Renderers;
using Chat.Esperance.Paperview.Views;
using Foundation;
using UIKit;
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

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {   // perform initial setup
                // lets get a reference to the native UIWebView
                var webView = this;

                // The following prevents the WebView having a black rectangle on the right when dragged left, also on the bottom when dragged up.
                Frame = new System.Drawing.RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                //webView.ScalesPageToFit = true;
            }
        }
    }
}
