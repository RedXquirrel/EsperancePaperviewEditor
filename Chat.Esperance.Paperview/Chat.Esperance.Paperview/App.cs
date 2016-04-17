using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chat.Esperance.Paperview.ViewModels;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview
{
    public class App : Application
    {
        
        public App()
        {
            var navigationPage = new NavigationPage(new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            });

            // The root page of your application
            MainPage = navigationPage;

            var nav = new Navigator(MainPage.Navigation);
            Navigator.Show(typeof(BootViewModel));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
