using System.Collections.Generic;
using Chat.Esperance.Paperview.ViewModels;

namespace Chat.Esperance.Paperview.DataSources
{
    public class MasterDetailItemGroupDataSource : List<MasterPageIndexItemViewModel>
    {
        private const string ExhibitsViewModelKey = "ExhibitsViewModel";
        private const string Error404ViewModelKey = "Error404ViewModel";
        private const string AddPublishersViewModelKey = "AddPublisherViewModel";
        private const string EditDocumentViewModelKey = "EditDocumentViewModel";

        public string Title { get; set; }
        public string ShortName { get; set; } // used for jump lists, must be 1 character
        public string Subtitle { get; set; }
        private MasterDetailItemGroupDataSource(string title, string shortName, string subtitle)
        {
            Title = title;
            ShortName = shortName;
            Subtitle = subtitle;
        }

        public static IList<MasterDetailItemGroupDataSource> Groups { private set; get; }

        static MasterDetailItemGroupDataSource()
        {
            List<MasterDetailItemGroupDataSource> Groups = new List<MasterDetailItemGroupDataSource>
            {
                new MasterDetailItemGroupDataSource("Gallery", "1", "A Flood of the Imagination")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf0c5", Title = "Exhibits", ViewModelName = ExhibitsViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf061", Title = "Import", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf14d", Title = "Share", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf29c", Title = "Help", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("Documents", "2", "Flood your imagination!")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf0c5", Title = "Directory", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf016", Title = "New", ViewModelName = EditDocumentViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf15b", Title = "Open", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf0c7", Title = "Save", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf0ea", Title = "Save As", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf0c8", Title = "Close", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf29c", Title = "Help", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("Templates", "3", "A Flood of different Layouts")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf0c5", Title = "Directory", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf061", Title = "Import", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf060", Title = "Export", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf014", Title = "Delete", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf29c", Title = "Help", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("Publishers", "4", "Manage who floods the market")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf0c5", Title = "Directory", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf016", Title = "New", ViewModelName = AddPublishersViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf15b", Title = "Open", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf0c7", Title = "Save", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf0c8", Title = "Close", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = false, IconKey = "\uf014", Title = "Delete", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf29c", Title = "Help", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("About", "5", "How to flood your market")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Paperview", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Document Types", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Layout Templates", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Custom Document Types", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Custom Templates", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf29c", Title = "Help", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("Developers", "6", "Customise how the flood looks")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "Creating Layout Templates", ViewModelName = Error404ViewModelKey },
                },
                new MasterDetailItemGroupDataSource("Corporate", "7", "Say hello to Captain Xamtastic")
                {
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf095", Title = "Contact Us", ViewModelName = Error404ViewModelKey },
                    new MasterPageIndexItemViewModel { IsPage = true, IconKey = "\uf005", Title = "About Captain Xamtastic", ViewModelName = Error404ViewModelKey },
                },
            };

            MasterDetailItemGroupDataSource.Groups = Groups;
        }

    }
}
