using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Pages;
using Chat.Esperance.Paperview.Pages.Publishers;
using Chat.Esperance.Paperview.ViewModels;

namespace Chat.Esperance.Paperview.Models
{
    public class PageTypeGroup : List<MasterPageItemViewModel>
    {
        public string Title { get; set; }
        public string ShortName { get; set; } // used for jump lists, must be 1 character
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
                new PageTypeGroup("Gallery", "1", "A Flood of the Imagination")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf0c5", Title = "Exhibits", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf061", Title = "Import", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf14d", Title = "Share", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf29c", Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Documents", "2", "Flood your imagination!")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf0c5", Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf016", Title = "New", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf15b", Title = "Open", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf0c7", Title = "Save", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf0ea", Title = "Save As", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf0c8", Title = "Close", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf29c", Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Templates", "3", "A Flood of different Layouts")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf0c5", Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf061", Title = "Import", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf060", Title = "Export", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf014", Title = "Delete", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf29c", Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Publishers", "4", "Manage who floods the market")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf0c5", Title = "Directory", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf016", Title = "New", IconSource = "icon.png", TargetType = typeof(NewPublishersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf15b", Title = "Open", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf0c7", Title = "Save", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf0c8", Title = "Close", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = false, IconKey = "\uf014", Title = "Delete", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf29c", Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("About", "5", "How to flood your market")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Paperview", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Custom Document Types", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Custom Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf29c", Title = "Help", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Developers", "6", "Customise how the flood looks")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "Creating Layout Templates", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
                new PageTypeGroup("Corporate", "7", "Say hello to Captain Xamtastic")
                {
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf095", Title = "Contact Us", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                    new MasterPageItemViewModel { IsStandard = true, IconKey = "\uf005", Title = "About Captain Xamtastic", IconSource = "icon.png", TargetType = typeof(DevelopersPhonePage) },
                },
            };
            All = Groups;
        }

    }
}
