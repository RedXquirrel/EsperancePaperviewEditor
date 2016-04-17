using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Pages;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi
{
    public static class Navigator
    {
        public const string _viewModelKey = "ViewModel";

        public static INavigation Navigation;
         
        public static void Show(Type viewModelType)
        {
            var name = viewModelType.Name;

            if (!name.Substring(name.Length - _viewModelKey.Length, _viewModelKey.Length).Equals(_viewModelKey))
            {
                throw new Exception($"ViewModel classname does not end in {_viewModelKey}, in {typeof(Navigator).Name} [{typeof(Navigator).AssemblyQualifiedName}]");
            }

            var abstractName = name.Substring(0, name.Length - _viewModelKey.Length);


            string pageName = string.Empty;

            switch (Device.Idiom)
            {
                 case TargetIdiom.Desktop:
                    pageName = abstractName + "Desktop" + "Page";
                    break;

                case TargetIdiom.Phone:
                    pageName = abstractName + "Phone" + "Page";
                    break;

                case TargetIdiom.Tablet:
                    pageName = abstractName + "Tablet" + "Page";
                    break;
            }

            // ToDo: this ties the API directly to the Forms UI assembly so create a DI service to obviate this.
            var pageType = typeof(Chat.Esperance.Paperview.Pages.BootPhonePage).GetTypeInfo().Assembly.ExportedTypes
                                          .FirstOrDefault(t => t.Name == pageName);

            if (pageType == null)
            {
                Debug.WriteLine($"WARNING: Page Not Found is {pageType.Name}");
            }
            else
            {
                Debug.WriteLine($"INFORMATION: Page to be activated is {pageType.Name}");
            }

            var page = Activator.CreateInstance(pageType) as ContentPage;

            if (page == null)
            {
            
            }
            else
            {
                Navigation.PushAsync(page);
            }
        }

        /* INavigation members
        public IReadOnlyList<Page> ModalStack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyList<Page> NavigationStack
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public void RemovePage(Page page)
        {
            throw new NotImplementedException();
        }
        */
    }
}
