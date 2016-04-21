using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels
{
    public class Error404ViewModel : ViewModelBase
    {
        private string _title = $"Error 404 View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}
