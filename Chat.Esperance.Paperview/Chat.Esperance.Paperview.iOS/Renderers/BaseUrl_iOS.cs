using System;
using System.Collections.Generic;
using System.Text;
using Chat.Esperance.Paperview.iOS.Renderers;
using Chat.Esperance.Paperview.Interfaces;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_iOS))]

namespace Chat.Esperance.Paperview.iOS.Renderers
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}
