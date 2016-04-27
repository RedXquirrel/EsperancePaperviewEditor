using Chat.Esperance.PaperviewApi.Scaffolding;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels.Documents
{
    public class EditDocumentViewModel : ViewModelBase
    {
        private string _title = $"Edit Document on {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}
