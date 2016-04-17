using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Interfaces;
using Chat.Esperance.Paperview.Pages;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview
{
    public class Navigator : INavigator
    {
        //public static INavigator Navigation { get; set; }

        private static INavigation _navigation { get; set; }

        public const string _viewModelKey = "ViewModel";

        public Navigator(INavigation navigation)
        {
            _navigation = navigation;
        }

        public static void Show(Type viewModelType)
        {
            var name = viewModelType.Name;

            if (!name.Substring(name.Length - _viewModelKey.Length, _viewModelKey.Length).Equals(_viewModelKey))
            {
                throw new Exception($"ViewModel classname does not end in {_viewModelKey}, in {typeof(Navigator).Name} [{typeof(Navigator).AssemblyQualifiedName}]");
            }

            var abstractName = name.Substring(0, name.Length - _viewModelKey.Length);

            switch (Device.Idiom)
            {
                case TargetIdiom.Desktop:
                    _navigation.PushAsync(new BootDesktopPage());
                    break;

                case TargetIdiom.Phone:
                    _navigation.PushAsync(new BootPhonePage());
                    break;

                case TargetIdiom.Tablet:
                    _navigation.PushAsync(new BootTabletPage());
                    break;
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
