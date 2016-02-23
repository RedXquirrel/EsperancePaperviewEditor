using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Chat.Esperance.Paperview.Core.Services;
using Paperview.Interfaces;
using Paperview.Microformats.B9889DB4_9D9A_4857_841B_CD5EB8E72FF0;

namespace Chat.Esperance.PaperviewTests
{
    [TestClass]
    public class PaperviewJsonFormatTests
    {
        private readonly string _generatedPaperviewFilesDirectoryPath;

        public PaperviewJsonFormatTests()
        {
            _generatedPaperviewFilesDirectoryPath = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Html5\\Generated\\";

            System.IO.DirectoryInfo di = new DirectoryInfo(_generatedPaperviewFilesDirectoryPath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        private string SampleJson_Photo_Collection_Microformat(string presentationId)
        {
            var legal = new Dictionary<string, object>
            {

            };

            var publisher = new Dictionary<string, object>
            {
                { "id", "Fake_Publisher_Id" }, /*  The Publisher Id as registered in the Esperance Content Portal */
                { "name", "Fake_Publisher" },  /*  The Legal Identity of the Publisher, as registered in the Esperance Content Portal and as associated with the above Publisher Id.*/
                { "email", "Fake_Email" },     /*  The email address of the Publisher */
                { "url", "Fake_WWW" }          /*  The Url of the Publisher */
            };

            var mfname = new Dictionary<string, object>
            {
                { "en", "Image Album" },
                { "de", "Fotosammlung" }
            };

            var mfdescription = new Dictionary<string, object>
            {
                { "en", "A Collection of images where each image has an associated name and description; the collection itself also has a name and description; all names and descriptions can be localised to any locale, with a default locale specified." },
                { "de", "To Be Translated" }
            };

            var mflanguagelist = new List<string>
            {
                "en", "de"
            };

            var microformat = new Dictionary<string, object>
            {
                { "mfid", "b9889db4-9d9a-4857-841b-cd5eb8e72ff0" },
                { "mfname", mfname },
                { "mfdescription", mfdescription },
                { "mflanguageavailability", mflanguagelist },
                { "mflanguagedefault", "en" },
                { "mfauthor", "Anthony Harrison" },
                { "mfauthoremailaddress", "anthony.harrison@xamtastic.com" },
                { "mfauthorwebaddress", "http://www.xamtastic.com" },
                { "mfderivation", "B9889DB4-9D9A-4857-841B-CD5EB8E72FF0" }
            };

            var image0names = new Dictionary<string, object>
            {
                { "en", "Blue Square" },
                { "de", "To Be Translated" }
            };

            var image0descriptions = new Dictionary<string, object>
            {
                { "en", "A Blue Square" },
                { "de", "To Be Translated" }
            };

            var image0 = new Dictionary<string, object>
            {
                { "base64", "data:image/javascript;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/4QAiRXhpZgAATU0AKgAAAAgAAQESAAMAAAABAAEAAAAAAAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAB+AHUDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD5Pooor/RA+DCiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAP/2Q==" },
                { "name", image0names },
                { "description", image0descriptions }
            };

            var images = new List<Dictionary<string, object>>
            {
                image0, /* image1, image2, image3 */
            };

            var artefacttitles= new Dictionary<string, object>
            {
                { "en", "Collection Title" },
                { "de", "To Be Translated" }
            };

            var artefactdescriptions = new Dictionary<string, object>
            {
                { "en", "Collection Description" },
                { "de", "To Be Translated" }
            };

            var artifacts = new Dictionary<string, object>
            {
                { "title", artefacttitles },
                { "description", artefactdescriptions },
                { "images", images }
            };

            var document = new Dictionary<string, object>()
            {
                { "documentId", Guid.NewGuid().ToString().ToLowerInvariant() },
                { "microformatId", "b9889db4-9d9a-4857-841b-cd5eb8e72ff0" },
                { "presentationId", presentationId.ToLowerInvariant() },
                { "microformat", microformat }
            };

            var root = new Dictionary<string, object>
            {
                { "document", document },
                { "legal", legal },
                { "publisher", publisher },
                { "artifacts", artifacts }
            };

            var response = JsonConvert.SerializeObject(root);

            return response;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var photocollectionjson = SampleJson_Photo_Collection_Microformat("3F36D2CA-8A54-4826-8F6A-5D83004C7ED8");

            var embed = @"<script id='esperance'>var json = '" + photocollectionjson + "';</ script>";

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void DeserialiseJsonTest()
        {
            var json = SampleJson_Photo_Collection_Microformat("3F36D2CA-8A54-4826-8F6A-5D83004C7ED8");

            var obj = JsonConvert.DeserializeObject<Microformat_B9889DB4_9D9A_4857_841B_CD5EB8E72FF0>(json);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CreateTest()
        {
            var objList = new List<object>();

            // Note: 

            objList.Add(JsonConvert.DeserializeObject<Microformat_B9889DB4_9D9A_4857_841B_CD5EB8E72FF0>(SampleJson_Photo_Collection_Microformat("3F36D2CA-8A54-4826-8F6A-5D83004C7ED8")));
            objList.Add(JsonConvert.DeserializeObject<Microformat_B9889DB4_9D9A_4857_841B_CD5EB8E72FF0>(SampleJson_Photo_Collection_Microformat("3F36D2CA-8A54-4826-8F6A-5D83004C7ED8")));
            objList.Add(JsonConvert.DeserializeObject<Microformat_B9889DB4_9D9A_4857_841B_CD5EB8E72FF0>(SampleJson_Photo_Collection_Microformat("3F36D2CA-8A54-4826-8F6A-5D83004C7ED8")));

            
            IMicroformatService service = new MicroformatService(new MockMicroformatTemplateService());

            using (service.CreateFactory())
            {
                foreach (var item in objList)
                {
                    service.Create(item);
                }
            }
            var documents = service.GetDocuments();
            service.Close();

            

            foreach (var item in documents.Keys)
            {
                Debug.WriteLine($"Document Id: {item}");
                Debug.WriteLine($"Document Content: {documents[item]}");
                
                if (!string.IsNullOrEmpty(_generatedPaperviewFilesDirectoryPath))
                {
                    System.IO.File.WriteAllText($"{_generatedPaperviewFilesDirectoryPath}{item}.html", documents[item]);
                }
            }

            



            

            Assert.IsTrue(true);
        }
    }
}
