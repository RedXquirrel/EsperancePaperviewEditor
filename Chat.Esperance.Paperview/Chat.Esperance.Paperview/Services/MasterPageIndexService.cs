using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.DataSources;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.Services
{
    public class MasterPageIndexService
    {
        public static IList<MasterDetailItemGroupDataSource>  Index { get; set; }

        static MasterPageIndexService()
        {
            Index = MasterDetailItemGroupDataSource.Groups;
        }
    }
}
