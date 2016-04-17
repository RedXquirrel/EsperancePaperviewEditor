using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Pages;
using Chat.Esperance.PaperviewApi.ViewModels;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi
{
    public static class Navigator
    {
        private const string ViewModelKey = "ViewModel";
        private const string PageKey = "Page";
        private const string DesktopIdiomKey = "Desktop";
        private const string PhoneIdiomKey = "Phone";
        private const string TabletIdiomKey = "Tablet";

        public static INavigation Navigation;
        public static Assembly UiAssembly;

        public static Page CurrentPage { get; set; }

        public static async void Show(Type viewModelType)
        {
            var name = viewModelType.Name;

            if (!name.Substring(name.Length - ViewModelKey.Length, ViewModelKey.Length).Equals(ViewModelKey))
            {
                throw new Exception($"ViewModel classname does not end in {ViewModelKey}, in {typeof(Navigator).Name} [{typeof(Navigator).AssemblyQualifiedName}]");
            }

            var abstractName = name.Substring(0, name.Length - ViewModelKey.Length);


            var pageName = string.Empty;

            switch (Device.Idiom)
            {
                 case TargetIdiom.Desktop:
                    pageName = abstractName + DesktopIdiomKey + PageKey;
                    break;

                case TargetIdiom.Phone:
                    pageName = abstractName + PhoneIdiomKey + PageKey;
                    break;

                case TargetIdiom.Tablet:
                    pageName = abstractName + TabletIdiomKey + PageKey;
                    break;
                case TargetIdiom.Unsupported:
                    throw new Exception("This Device Idiom is unsupported.");
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var pageType = UiAssembly.ExportedTypes.FirstOrDefault(t => t.Name == pageName);

            Debug.WriteLine(pageType == null ? $"WARNING: Page Not Found is {pageName}" : $"INFORMATION: Page to be activated is {pageType.Name}");

            var viewModel = Activator.CreateInstance(viewModelType) as ViewModelBase;
            if (viewModel != null && viewModel.IsGhosted) return;

            var page = Activator.CreateInstance(pageType) as ContentPage;

            NavigationPage.SetHasNavigationBar(page, false); // The default is to not have a navigation bar!

            if (page == null || viewModel == null)
            {
                if(page == null && viewModel == null) throw new Exception($"Both Page and ViewModel not found ({pageName} and {viewModelType.Name})");
                if(page == null) throw new Exception($"Page Not Found is {pageName}");
                if(viewModel == null) throw new Exception($"ViewModel Not Found is {viewModelType.Name}");
            }
            else
            {
                // So that application lifecycle methods can be called (OnStart, OnSleep, OnResume):
                PaperviewApplication.CurrentViewModel = viewModel;
                // Store the current page 
                Navigator.CurrentPage = page;
                // Bind the ViewModel to the Page:
                page.BindingContext = viewModel;
                // Navigate to the Page:
                await Navigation.PushAsync(page);
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
