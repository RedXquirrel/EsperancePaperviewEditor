using Chat.Esperance.PaperviewApi.Scaffolding;
using Chat.Esperance.PaperviewApi.Services;
using Paperview.Common;
using Xamarin.Forms;

namespace Chat.Esperance.PaperviewApi.ViewModels.Publishers
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
                    Email = "anthony.harrison@xamtastic.com",
                    Name = "Anthony Harrison",
                    Id = "Paperview/E85D8EFD-D395-41BA-A0A6-5E858A9E9238",
                    Url = "http://www.xamtastic.com"
                };

                var response = PublishersService.AddPublisher(publisher);

                publisher = new Publisher
                {
                    Email = "captain@captainxamtastic.com",
                    Name = "Captain Xamtastic",
                    Id = "Paperview/2011660F-E563-4793-BFEC-16101ED89D34",
                    Url = "http://www.CaptainXamtastic.com"
                };

                PublishersService.SetDefaultPublishersId(publisher.Id.ToLower());

                response = PublishersService.AddPublisher(publisher);

                publisher = new Publisher
                {
                    Email = "publisher@captainxamtastic.com",
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
