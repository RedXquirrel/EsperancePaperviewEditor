namespace Chat.Esperance.Paperview.ViewModels
{
    public class BootViewModel : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}