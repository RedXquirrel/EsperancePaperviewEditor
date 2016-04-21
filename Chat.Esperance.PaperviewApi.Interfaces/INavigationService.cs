using System;
using System.Reflection;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.Interfaces
{
    public interface INavigationService
    {
        INavigation Navigation { get; set; }
        Assembly UiAssembly { get; set; }
        Page CurrentPage { get; set; }

        void Show(Type viewModelType);
        void Show(string viewModelName);

        Page GetBoundPage(Type viewModelType);
        Page GetBoundPage(String viewModelName);

        object GetViewModel(string viewModelName);
    }
}