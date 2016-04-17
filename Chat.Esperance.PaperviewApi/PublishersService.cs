using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Esperance.PaperviewApi.Helpers;
using Newtonsoft.Json;
using Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0;

namespace Chat.Esperance.PaperviewApi
{
    public enum PublishingServiceResponse
    {
        Ok,
        PublisherExistsWithSameId   
    }

    public static class PublishersService
    {
        public static List<Publisher> GetPublishers()
        {
            return JsonConvert.DeserializeObject<List<Publisher>> (Settings.Publishers);
        }

        public static PublishingServiceResponse AddPublisher(Publisher publisher)
        {
            var response = PublishingServiceResponse.Ok;
            var list = GetPublishers();
            if (list.Count(pub => pub.Id.ToLower() == publisher.Id.ToLower()) == 0)
            {
                publisher.Id = publisher.Id.ToLower();
                list.Add(publisher);
                Settings.Publishers = JsonConvert.SerializeObject(list);
            }
            else
            {
                response = PublishingServiceResponse.PublisherExistsWithSameId;
            }

            return response;
        }
    }
}
