using System;
using Chat.Esperance.Paperview.Scaffolding;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.ViewModels
{
    public class MasterPageIndexItemViewModel : ViewModelBase
    {
        private string _iconKey;

        /// <summary>
        /// The unicode icon-font key, eg "\uf0c5"
        /// </summary>
        public string IconKey
        {
            get { return _iconKey; }
            set { _iconKey = value; RaisePropertyChanged(); }
        }

        private string _title;
        /// <summary>
        /// The Index Item text
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        private string _viewModelName;
        /// <summary>
        /// The name of the ViewModel to navigate to
        /// </summary>
        public string ViewModelName
        {
            get { return _viewModelName; }
            set { _viewModelName = value; RaisePropertyChanged(); }
        }

        private bool _isPage;
        /// <summary>
        /// Does the item represent a Page of a Page Function (i.e. navigate to page but pass parameter), used for DataTemplate selection
        /// </summary>
        // ToDo: Change this to an enumeration
        public bool IsPage
        {
            get { return _isPage; }
            set { _isPage = value; RaisePropertyChanged(); }
        }
    }
}
