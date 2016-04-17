using System;
using System.Reflection;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Chat.Esperance.Paperview.ViewModels;
using Chat.Esperance.PaperviewApi;
using Chat.Esperance.PaperviewApi.ViewModels;

namespace Chat.Esperance.Paperview.Droid
{
    [Activity(Label = "Chat.Esperance.Paperview", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        /// <summary>
        /// The Paperviewe API
        /// </summary>
        protected PaperviewApplication PaperviewApplication = new PaperviewApplication();
        /// <summary>
        /// The Forms UI that is bound to ViewModels in the Paperview API
        /// </summary>
        protected FormsApplication FormsApplication;
        
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            FormsApplication = new FormsApplication();
            LoadApplication(FormsApplication); // This is just the standard App() recreated with a Xaml ResourceDictionary

            // When the Xamarin.Forms lifecyle overrides fire, they need to invoke the PaperviewApplication lifecycle Actions.
            FormsApplication.OnStartAction = PaperviewApplication.OnStart();
            FormsApplication.OnSleepAction = PaperviewApplication.OnSleep();
            FormsApplication.OnResumeAction = PaperviewApplication.OnResume();

            // Identify to the Navigator, which assembly the UI is in (a reference to any class will do):
            Chat.Esperance.PaperviewApi.Navigator.UiAssembly =
                typeof(Chat.Esperance.Paperview.Pages.BootPhonePage).GetTypeInfo().Assembly;
            // Pass the Forms Navigation utility to the PaperviewApplication's Navigator
            Chat.Esperance.PaperviewApi.Navigator.Navigation = FormsApplication.Navigation;
            // Navigate to the initial ViewModel:
            Chat.Esperance.PaperviewApi.Navigator.Show(typeof(BootViewModel));  // n.b Don't do this in the PaperviewAPI OnStart action as
                                                                                // on iOS it must be called earlier (hence it is done here).
        }
    }
}

