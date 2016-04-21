using System;
using Autofac;
using Chat.Esperance.PaperviewApi.Interfaces;
using Chat.Esperance.PaperviewApi.Services;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels
{
    public class BootViewModel : ViewModelBase
    {
        private string _title = $"Boot View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        public BootViewModel()
        {
            IsGhosted = true;
            ChooseTargetPage();
        }

        /// <summary>
        /// This is reserved to determine which page to navigate to, depending upon whether a user is logged in or not.
        /// </summary>
        private void ChooseTargetPage()
        {

            using (var scope = DI.Container.BeginLifetimeScope())
            {
                var navigationService = scope.Resolve<INavigationService>();

                // ToDo: Create boot-sequence such as to divert to login if not logged in
                // var userService = scope.Resolve<IUserService>();

                //if (userService.IsLoggedIn)
                //{
                    navigationService.Show(typeof(MainViewModel));
                //}
                //else
                //{
                //    service.Show(typeof(LoggedOutViewModel));
                //}
            }
        }

    }
}