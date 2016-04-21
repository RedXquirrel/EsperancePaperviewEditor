using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.ViewModels;
using Xamarin.Forms;
using Chat.Esperance.Paperview.Services;

namespace Chat.Esperance.Paperview.Pages
{
    public partial class MasterPhonePage : ContentPage
    {
        public ListView ListView { get { return listView;  } }

        public MasterPhonePage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
               
            }

            ListView.ItemsSource = MasterPageIndexService.Index;
        }
    }
}
