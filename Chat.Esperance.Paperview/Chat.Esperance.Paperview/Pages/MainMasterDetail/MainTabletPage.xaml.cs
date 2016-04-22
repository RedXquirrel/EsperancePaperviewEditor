using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Chat.Esperance.Paperview.Pages.Gallery;
using Chat.Esperance.Paperview.ViewModels;
using Chat.Esperance.PaperviewApi.Interfaces;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Pages.MainMasterDetail
{
    public partial class MainTabletPage : MasterDetailPage
    {
        public MainTabletPage()
        {

                InitializeComponent();
            //try
            //{
            //    NavigationPage.SetHasNavigationBar(this, false);
            //    using (var scope = DI.Container.BeginLifetimeScope())
            //    {
            //        var service = scope.Resolve<INavigationService>();
            //        this.ExhibitsTabletPage.BindingContext = service.GetViewModel("ExhibitsViewModel");
            //        this.masterTabletPage.ListView.SelectedItem = null;
            //        IsPresented = false;
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            //this.masterTabletPage.ListView.ItemSelected += ItemSelected;
        }

        //private void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as MasterPageIndexItemViewModel;

        //    if (item?.ViewModelName == null) return;

        //    using (var scope = DI.Container.BeginLifetimeScope())
        //    {
        //        var service = scope.Resolve<INavigationService>();
        //        Detail = new NavigationPage(service.GetBoundPage(item.ViewModelName));
        //        this.masterTabletPage.ListView.SelectedItem = null;
        //        IsPresented = false;
        //    }
        //}
    }
}
