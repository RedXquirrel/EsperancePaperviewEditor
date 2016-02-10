using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Chat.Esperance.PaperviewTests
{
    [TestClass]
    public class PaperviewJsonFormatTests
    {

        private string SampleJson_Photo_Collection_Microformat()
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

            var mfname_en = new Dictionary<string, object>
            {
                { "en", "Photo Collection" }
            };

            var mfname_de = new Dictionary<string, object>
            {
                { "de", "Fotosammlung" }
            };

            var mfname = new List<Dictionary<string, object>>
            {
                mfname_en, mfname_de
            };

            var mfdescription_en = new Dictionary<string, object>
            {
                { "en", "A Collection of Photographs" }
            };

            var mfdescription_de = new Dictionary<string, object>
            {
                { "de", "To Be Translated" }
            };

            var mfdescription = new List<Dictionary<string, object>>
            {
                mfdescription_en, mfdescription_de
            };

            var mflanguagelist = new List<string>
            {
                "en", "de"
            };

            var microformat = new Dictionary<string, object>
            {
                { "mf-id", "B9889DB4-9D9A-4857-841B-CD5EB8E72FF0" },
                { "mf-name", mfname },
                { "mf-description", mfdescription },
                { "mf-language-availability", mflanguagelist },
                { "mf-language-default", "en" },
                { "mf-author", "Anthony Harrison" },
                { "mf-author-emailaddress", "anthony.harrison@xamtastic.com" },
                { "mf-derivation", null }
            };


            var image0 = new Dictionary<string, object>
            {
                { "base64", "data:image/javascript;base64,/9j/4AAQSkZJRgABAQEAYABgAAD/4QAiRXhpZgAATU0AKgAAAAgAAQESAAMAAAABAAEAAAAAAAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAB+AHUDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD5Pooor/RA+DCiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiiigAooooAKKKKAP/2Q==" },
                { "name", "Token Name 1" },
                { "description", "Token Description 1" }
            };

            var images = new List<Dictionary<string, object>>
            {
                image0, /* image1, image2, image3 */
            };

            var artifacts = new Dictionary<string, object>
            {
                { "title", "Collection Title" },
                { "description", "Collection Description" },
                { "images", images }
            };

            var root = new Dictionary<string, object>
            {
                { "legal", legal },
                { "publisher", publisher },
                { "microformat", microformat },
                { "artifacts", artifacts }
            };

            return JsonConvert.SerializeObject(root);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var photocollectionjson = SampleJson_Photo_Collection_Microformat();

            var embed = @"<script id='esperance'>var json = '" + photocollectionjson + "';</ script>";

            Assert.IsTrue(true);
        }
    }
}
