using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Chat.Esperance.PaperviewApi.Interfaces;
using Chat.Esperance.PaperviewApi.Scaffolding;
using Chat.Esperance.PaperviewApi.ViewModels;
using Chat.Esperance.PaperviewApi.ViewModels.MainMasterDetail;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.Services
{
    public class NavigationService : INavigationService
    {
        private const string ViewModelKey = "ViewModel";
        private const string PageKey = "Page";
        private const string DesktopIdiomKey = "Desktop";
        private const string PhoneIdiomKey = "Phone";
        private const string TabletIdiomKey = "Tablet";

        public INavigation Navigation { get; set; }
        public Assembly UiAssembly { get; set; }
        public Page CurrentPage { get; set; }

        public Action<bool> MasterDetailAction { get; set; } 
        public bool MasterDetailIsOpen { get; set; }

        public async void Show(Type viewModelType)
        {
            Type pageType;
            var pageName = PageName(viewModelType, out pageType);

            Debug.WriteLine(pageType == null ? $"WARNING: Page Not Found is {pageName}" : $"INFORMATION: Page to be activated is {pageType.Name}");

            var viewModel = Activator.CreateInstance(viewModelType) as ViewModelBase;
            if (viewModel != null && viewModel.IsGhosted) return; // 'Ghosted' ViewModels are not intended to be bound to a page! (They typically determine which other ViewModel to Show (such as in the BootViewModel)!)
            
            var page = Activator.CreateInstance(pageType) as Page;

            if (page == null || viewModel == null)
            {
                if(page == null && viewModel == null) throw new Exception($"Both Page and ViewModel not found ({pageName} and {viewModelType.Name})");
                if(page == null) throw new Exception($"Page Not Found is {pageName}");
                //if(viewModel == null) throw new Exception($"ViewModel Not Found is {viewModelType.Name}");
            }
            else
            {
                // The default is to not have a navigation bar!
                NavigationPage.SetHasNavigationBar(page, false); 
                // So that application lifecycle methods can be called (OnStart, OnSleep, OnResume):
                PaperviewApplication.CurrentViewModel = viewModel;
                // Store the current page 
                CurrentPage = page;

                if (viewModel.GetType() != typeof (MainViewModel)) // Binding is in code-behind as this is the app's MasterDetailPage
                {
                    // Bind the ViewModel to the Page:
                    page.BindingContext = viewModel;
                }
                // Navigate to the Page:
                await Navigation.PushAsync(page);
            }
        }

        private string PageName(Type viewModelType, out Type pageType)
        {
            var name = viewModelType.Name;

            if (!name.Substring(name.Length - ViewModelKey.Length, ViewModelKey.Length).Equals(ViewModelKey))
            {
                throw new Exception(
                    $"ViewModel classname does not end in {ViewModelKey}, in {typeof (NavigationService).Name} [{typeof (NavigationService).AssemblyQualifiedName}]");
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

            pageType = UiAssembly.ExportedTypes.FirstOrDefault(t => t.Name == pageName);
            return pageName;
        }

        public void Show(string viewModelName)
        {
            var viewModelType =
                this.GetType().GetTypeInfo().Assembly.ExportedTypes.FirstOrDefault(t => t.Name == viewModelName);
            Show(viewModelType);
        }

        public Page GetBoundPage(Type viewModelType)
        {
            Type pageType;
            var pageName = PageName(viewModelType, out pageType);

            Debug.WriteLine(pageType == null ? $"WARNING: Page Not Found is {pageName}" : $"INFORMATION: Page to be activated is {pageType.Name}");

            var viewModel = Activator.CreateInstance(viewModelType) as ViewModelBase;

            var page = Activator.CreateInstance(pageType) as Page;

            if (page == null) throw new Exception($"Page Not Found is {pageName}");

            page.BindingContext = viewModel;

            return page;
        }

        public Page GetBoundPage(string viewModelName)
        {
            return GetBoundPage(this.GetType().GetTypeInfo().Assembly.ExportedTypes.FirstOrDefault(t => t.Name == viewModelName));
        }

        public object GetViewModel(string viewModelName)
        {
            var viewModelType = this.GetType().GetTypeInfo().Assembly.ExportedTypes.FirstOrDefault(t => t.Name == viewModelName);

            return Activator.CreateInstance(viewModelType) as ViewModelBase;
        }
    }
}
