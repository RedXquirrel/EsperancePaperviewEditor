using Chat.Esperance.PaperviewApi.Scaffolding;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels.Gallery
{
    public class ExhibitsViewModel : ViewModelBase
    {
        private string _title = $"Exhibits View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}
