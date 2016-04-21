using Chat.Esperance.PaperviewApi.Scaffolding;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels.Publishers
{
    public class AddPublisherViewModel : ViewModelBase
    {
        private string _title = $"Add Publisher View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}
