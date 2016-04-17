using System;
using Chat.Esperance.PaperviewApi.ViewModels;

namespace Chat.Esperance.PaperviewApi
{
    public class PaperviewApplication
    {
        public static ViewModelBase CurrentViewModel { get; set; }

        public Action OnStart()
        {
            return () =>
            {
                CurrentViewModel.OnStart();
            };
        }

        public Action OnSleep()
        {
            return () =>
            {
                CurrentViewModel.OnSleep();
            };
        }

        public Action OnResume()
        {
            return () =>
            {
                CurrentViewModel.OnResume();
            };
        }
    }
}