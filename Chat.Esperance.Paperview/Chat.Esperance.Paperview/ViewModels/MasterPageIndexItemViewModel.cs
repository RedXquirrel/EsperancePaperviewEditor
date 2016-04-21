using System;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.ViewModels
{
    public class MasterPageIndexItemViewModel
    {
        /// <summary>
        /// The unicode icon-font key, eg "\uf0c5"
        /// </summary>
        public string IconKey { get; set; }
        /// <summary>
        /// The Index Item text
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The name of the ViewModel to navigate to
        /// </summary>
        public string ViewModelName { get; set; }
        /// <summary>
        /// Does the item represent a Page of a Page Function (i.e. navigate to page but pass parameter), used for DataTemplate selection
        /// </summary>
        // ToDo: Change this to an enumeration
        public bool IsPage { get; set; }
    }
}
