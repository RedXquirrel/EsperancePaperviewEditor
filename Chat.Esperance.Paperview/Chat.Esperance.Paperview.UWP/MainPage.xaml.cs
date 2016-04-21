using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Chat.Esperance.PaperviewApi;
using Chat.Esperance.PaperviewApi.Services;
using Chat.Esperance.PaperviewApi.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Chat.Esperance.Paperview.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        /// <summary>
        /// The Paperviewe API
        /// </summary>
        private readonly PaperviewApplication _paperviewApplication = new PaperviewApplication();
        /// <summary>
        /// The Forms UI that is bound to ViewModels in the Paperview API
        /// </summary>
        private readonly FormsApplication _formsApplication;

        public MainPage()
        {
            this.InitializeComponent();
            _formsApplication = new FormsApplication();
            LoadApplication(_formsApplication); // This is just the standard App() recreated with a Xaml ResourceDictionary

            // When the Xamarin.Forms lifecyle overrides fire, they need to invoke the PaperviewApplication lifecycle Actions.
            FormsApplication.OnStartAction = _paperviewApplication.OnStart();
            FormsApplication.OnSleepAction = _paperviewApplication.OnSleep();
            FormsApplication.OnResumeAction = _paperviewApplication.OnResume();

            // Identify to the Navigator, which assembly the UI is in (a reference to any class will do):
            //NavigationService.UiAssembly =
            //    typeof(Chat.Esperance.Paperview.Pages.BootPhonePage).GetTypeInfo().Assembly;
            // Pass the Forms Navigation utility to the PaperviewApplication's ViewModel Navigator
            //NavigationService.Navigation = FormsApplication.Navigation;
            // Navigate to the initial ViewModel:
            //NavigationService.Show(typeof(BootViewModel));  // This cannot be done in the PaperviewAPI OnStart action
                                                            // because on iOS a Navigation.Push(...) must occur before
                                                            // the following line after this - base.FinishedLaunching(...) - is returned.
        }
    }
}
