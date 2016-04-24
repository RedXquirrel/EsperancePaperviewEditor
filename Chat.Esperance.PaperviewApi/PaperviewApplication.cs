using System;
using Chat.Esperance.PaperviewApi.Scaffolding;
using Chat.Esperance.PaperviewApi.ViewModels;
using Paperview.StockDocumentTypes;

namespace Chat.Esperance.PaperviewApi
{
    public class PaperviewApplication
    {
        public static ViewModelBase CurrentViewModel { get; set; }

        public PaperviewApplication()
        {
            StockDocumentTypes.Init();
        }

        public Action OnStart()
        {
            return () =>
            {
                CurrentViewModel?.OnStart();
            };
        }

        public Action OnSleep()
        {
            return () =>
            {
                CurrentViewModel?.OnSleep();
            };
        }

        public Action OnResume()
        {
            return () =>
            {
                CurrentViewModel?.OnResume();
            };
        }
    }
}