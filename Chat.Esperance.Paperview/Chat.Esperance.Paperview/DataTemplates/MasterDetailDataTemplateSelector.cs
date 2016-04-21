using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.Paperview.DataTemplates.CustomCells;
using Chat.Esperance.Paperview.ViewModels;
using Xamarin.Forms;

namespace Chat.Esperance.Paperview.DataTemplates
{
    public class MasterDetailDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public MasterDetailDataTemplateSelector()
        {
            this.pageDataTemplate = new DataTemplate(typeof(PageCell));
            this.functionDataTemplate = new DataTemplate(typeof(FunctionCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as MasterPageItemViewModel;
            if (messageVm == null)
                return null;
            return messageVm.IsStandard ? this.pageDataTemplate : this.functionDataTemplate;
        }

        private readonly DataTemplate pageDataTemplate;
        private readonly DataTemplate functionDataTemplate;
    }
}
