﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Chat.Esperance.PaperviewApi;
using Chat.Esperance.PaperviewApi.Interfaces;
using Chat.Esperance.PaperviewApi.Services;
using Chat.Esperance.PaperviewApi.ViewModels;
using Chat.Esperance.PaperviewApi.ViewModels.Boot;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        /// <summary>
        /// The Paperviewe API
        /// </summary>
        protected PaperviewApplication PaperviewApplication = new PaperviewApplication();
        /// <summary>
        /// The Forms UI that is bound to ViewModels in the Paperview API
        /// </summary>
        protected FormsApplication FormsApplication;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            FormsApplication = new FormsApplication();
            LoadApplication(FormsApplication); // This is just the standard App() recreated with a Xaml ResourceDictionary

            // When the Xamarin.Forms lifecyle overrides fire, they need to invoke the PaperviewApplication lifecycle Actions.
            FormsApplication.OnStartAction = PaperviewApplication.OnStart();
            FormsApplication.OnSleepAction = PaperviewApplication.OnSleep();
            FormsApplication.OnResumeAction = PaperviewApplication.OnResume();

            var builder = new ContainerBuilder();

            builder.RegisterInstance(new NavigationService()).As<INavigationService>();

            DI.Container = builder.Build();

            // This cannot be done in the PaperviewAPI OnStart action
            // because on iOS a Navigation.Push(...) must occur before
            // the following base.FinishedLaunching(...) is returned.
            using (var scope = DI.Container.BeginLifetimeScope())
            {
                var service = scope.Resolve<INavigationService>();
                service.UiAssembly = typeof(Chat.Esperance.Paperview.Pages.MasterPhonePage).GetTypeInfo().Assembly;
                service.Navigation = FormsApplication.Navigation;
                service.Show(typeof(BootViewModel));
            }

            return base.FinishedLaunching(app, options);
        }
    }
}
