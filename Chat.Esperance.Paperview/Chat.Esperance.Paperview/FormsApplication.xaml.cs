using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Chat.Esperance.Paperview
{
    public partial class FormsApplication : Application
    {
        /// <summary>
        /// The Xamarin.Forms Interface abstracting platform-specific navigation
        /// </summary>
        public static INavigation Navigation { get; set; }

        /// <summary>
        /// The API Application OnStart Action
        /// </summary>
        public static Action OnStartAction { get; set; }
        /// <summary>
        ///  The API Application OnSleep Action
        /// </summary>
        public static Action OnSleepAction { get; set; }
        /// <summary>
        /// The API Application OnResume Action
        /// </summary>
        public static Action OnResumeAction { get; set; }

        public FormsApplication()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage();

            Navigation = navigationPage.Navigation;

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            OnStartAction?.Invoke();
        }

        protected override void OnSleep()
        {
            OnSleepAction?.Invoke();
        }

        protected override void OnResume()
        {
            OnResumeAction?.Invoke();
        }

    }
}
