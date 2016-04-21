using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.Models;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Services
{
    public class MasterPageIndexService
    {
        public static IList<PageTypeGroup>  Index { get; set; }

        static MasterPageIndexService()
        {
            Index = PageTypeGroup.All;
        }
    }
}
