using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.ViewModels;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Pages
{
    public partial class MainPhonePage : MasterDetailPage
    {
        public MainPhonePage()
        {
            try
            {
                InitializeComponent();
                NavigationPage.SetHasNavigationBar(this,false);
            }
            catch (Exception ex)
            {
                
            }
            masterPhonePage.ListView.ItemSelected += ItemSelected;
        }

        private void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItemViewModel;

            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPhonePage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
