using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Pages.Developers;
using Xamarin.Forms;

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

            
            ListView.ItemsSource = PageTypeGroup.All;
            //var documentPageItems = new List<MasterPageItem>();
            //documentPageItems.Add(new MasterPageItem { Title = "Gallery", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //DocumentsListView.ItemsSource = documentPageItems;
            //SizeListView(DocumentsListView, documentPageItems);

            //var editorPageItems = new List<MasterPageItem>();
            //editorPageItems.Add(new MasterPageItem { Title = "New", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //editorPageItems.Add(new MasterPageItem { Title = "Open", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //editorPageItems.Add(new MasterPageItem { Title = "Save", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //editorPageItems.Add(new MasterPageItem { Title = "Close", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //editorPageItems.Add(new MasterPageItem { Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //EditorListView.ItemsSource = editorPageItems;
            //EditorListView.HeightRequest = editorPageItems.Count * _itemHeight;

            //var aboutPageItems = new List<MasterPageItem>();
            //aboutPageItems.Add(new MasterPageItem { Title = "Paperview", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //aboutPageItems.Add(new MasterPageItem { Title = "Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //aboutPageItems.Add(new MasterPageItem { Title = "Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //aboutPageItems.Add(new MasterPageItem { Title = "Custom Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //aboutPageItems.Add(new MasterPageItem { Title = "Custom Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //AboutListView.ItemsSource = aboutPageItems;
            //AboutListView.HeightRequest = aboutPageItems.Count * _itemHeight;

            //var developersPageItems = new List<MasterPageItem>();
            //developersPageItems.Add(new MasterPageItem { Title = "Creating Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //DevelopersListView.ItemsSource = developersPageItems;

            //var corporatePageItems = new List<MasterPageItem>();
            //corporatePageItems.Add(new MasterPageItem { Title = "Contact Us", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //corporatePageItems.Add(new MasterPageItem { Title = "About Captain Xamtastic", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) });
            //CorporateListView.ItemsSource = corporatePageItems;
        }

        //private void SizeListView(ListView listView, List<MasterPageItem> itemSource)
        //{
        //    listView.HeightRequest = itemSource.Count*_itemHeight;
        //}
    }

    public class PageTypeGroup : List<MasterPageItem>
    {
        public string Title { get; set; }
        public string ShortName { get; set; } //will be used for jump lists
        public string Subtitle { get; set; }
        private PageTypeGroup(string title, string shortName, string subtitle)
        {
            Title = title;
            ShortName = shortName;
            Subtitle = subtitle;
        }

        public static IList<PageTypeGroup> All { private set; get; }

        static PageTypeGroup()
        {
            List<PageTypeGroup> Groups = new List<PageTypeGroup>
            {
                new PageTypeGroup("Gallery", "1", "A Flood of the Imagination!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Directory (default)", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Share", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Documents", "2", "Flood your imagination!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "New", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Open", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Save", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Close", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Templates", "3", "A Flood of different Layouts!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Import", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Export", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Delete", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Publishers", "4", "Manage who floods the market!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "New", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Open", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Save", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Save As", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Close", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = false, Title = "Delete", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("About", "5", "How to flood your market!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Paperview", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Custom Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Custom Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Developers", "6", "Customise how the flood looks!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Creating Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Corporate", "7", "Say hello to Captain Xamtastic!")
                {
                    new MasterPageItem { IsStandard = true, Title = "Contact Us", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItem { IsStandard = true, Title = "About Captain Xamtastic", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
            };
            All = Groups;
        }

    }
}
