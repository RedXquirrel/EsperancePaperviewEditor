using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Services;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Pages.MainMasterDetail
{
    public partial class MasterTabletPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterTabletPage()
        {
            try
            {
                InitializeComponent();

                NavigationPage.SetHasNavigationBar(this, false);
            }
            catch (Exception ex)
            {

            }

            ListView.ItemsSource = MasterPageIndexService.Index;
        }
    }
}
