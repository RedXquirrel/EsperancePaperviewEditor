using System;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.ViewModels
{
    public class MasterPageItemViewModel
    {
        public string IconKey { get; set; }
        public string Title { get; set; }
        public ImageSource IconSource { get; set; }
        public Type TargetType { get; set; }
        public bool IsStandard { get; set; }
    }
}
