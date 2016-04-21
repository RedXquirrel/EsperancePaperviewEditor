using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Pages.Developers;
using Chat.Esperance.Paperview.Pages.Publishers;
using Chat.Esperance.Paperview.ViewModels;
using Xamarin.Forms;
using Chat.Esperance.Paperview.Models;
using Chat.Esperance.Paperview.Services;

namespace Chat.Esperance.Paperview.Pages
{
    public partial class MasterPhonePage : ContentPage
    {
        public ListView ListView { get { return listView;  } }
        //private double _itemHeight = 30;
        //public ListView DocumentsListView { get { return documentsListView;  } }
        //public ListView EditorListView { get { return editorListView; } }
        //public ListView AboutListView {  get { return aboutListView; } }
        //public ListView DevelopersListView { get { return developersListView; } }
        //public ListView CorporateListView { get { return corporateListView; } }

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
