using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Chat.Esperance.Paperview.Interfaces;
using Xamarin.Forms;
using Chat.Esperance.PaperviewApi.Interfaces;

namespace Chat.Esperance.Paperview.Pages.Documents
{
    public partial class EditDocumentPhonePage : ContentPage
    {
        public EditDocumentPhonePage()
        {
            InitializeComponent();

            var htmlString = @"
                    <html>
                    <head>
                    </head>
                    <body style='background-color:green;'>
                    <h1>Error 404</h1>
                    <p>Page not found!</p>
                    </body>
                    </html>";

            using (var scope = DI.Container.BeginLifetimeScope())
            {
                var service = scope.Resolve<IDocumentTypeService>();
                htmlString = service.GetDocumentTypes().FirstOrDefault();
            }

            if (Device.OS != TargetPlatform.iOS)
            {
                var html = new HtmlWebViewSource();
                html.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
                html.Html = htmlString;

                BaseUrlWebView.Source = html;
            }
            else
            {
                var html = new HtmlWebViewSource();

                html.Html = htmlString;

                BaseUrlWebView.Source = html;

            }


        }
    }
}
