using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.PaperviewApi.Helpers;
using Chat.Esperance.PaperviewApi.Services;
using Newtonsoft.Json;
using Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0;
using Xamarin.Forms;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Chat.Esperance.PaperviewApi.ViewModels
{
    public class ManagePublishersViewModel : ViewModelBase
    {
        private string _title = $"Manage Publishers View Model Text on idiom {Device.Idiom.ToString()}";
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }

        public ManagePublishersViewModel()
        {
            if (PublishersService.GetPublishers().Count==0)
            {
                var publisher = new Publisher
                {
                    email = "anthony.harrison@xamtastic.com",
                    Name = "Anthony Harrison",
                    Id = "Paperview/E85D8EFD-D395-41BA-A0A6-5E858A9E9238",
                    Url = "http://www.xamtastic.com"
                };

                var response = PublishersService.AddPublisher(publisher);

                publisher = new Publisher
                {
                    email = "captain@captainxamtastic.com",
                    Name = "Captain Xamtastic",
                    Id = "Paperview/2011660F-E563-4793-BFEC-16101ED89D34",
                    Url = "http://www.CaptainXamtastic.com"
                };

                PublishersService.SetDefaultPublishersId(publisher.Id.ToLower());

                response = PublishersService.AddPublisher(publisher);

                publisher = new Publisher
                {
                    email = "publisher@captainxamtastic.com",
                    Name = "YouDoo Limited TA Xamtastic",
                    Id = "Paperview/D60B931C-E0F1-4716-83A3-682077E4AC10",
                    Url = "http://www.Xamtastic.com"
                };

                response = PublishersService.AddPublisher(publisher);
            }

            this.Title = this.Title + " " + PublishersService.GetPublisher(PublishersService.GetDefaultPublishersId()).Name;
        }
    }
}
