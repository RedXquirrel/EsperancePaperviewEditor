using System;
using System.Collections.Generic;
using System.Linq;
using Chat.Esperance.PaperviewApi.Helpers;
using Newtonsoft.Json;
using Paperview.Common;

namespace Chat.Esperance.PaperviewApi.Services
{
    public enum PublishingServiceResponse
    {
        Ok,
        PublisherExistsWithSameId   
    }

    public static class PublishersService
    {
        public static string GetDefaultPublishersId()
        {
            return Settings.DefaultPublishersId;
        }

        public static void SetDefaultPublishersId(string id)
        {
            Settings.DefaultPublishersId = id;
        }

        public static Publisher GetPublisher(string id)
        {
            return GetPublishers().FirstOrDefault(pub => pub.Id.Equals(id));
        }

        public static List<Publisher> GetPublishers()
        {
            return JsonConvert.DeserializeObject<List<Publisher>> (Settings.Publishers);
        }

        public static PublishingServiceResponse AddPublisher(Publisher publisher)
        {
            var response = PublishingServiceResponse.Ok;
            var list = GetPublishers();
            if (list.Count(pub => string.Equals(pub.Id, publisher.Id, StringComparison.CurrentCultureIgnoreCase)) == 0)
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
