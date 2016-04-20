using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview
{
    public class MasterPageItem
    {
        public string Title { get; set; }
        public ImageSource IconSource { get; set; }
        public Type TargetType { get; set; }
        public bool IsStandard { get; set; }
    }
}
