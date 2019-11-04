using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using Newtonsoft.Json;

namespace Data
{
    public class RSSReader
    {
        public static List<string> ReadRss(string URL)
        {
            string url = "https://whenwewerekings.libsyn.com/rss";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            var counter = 0;
            var AvsnittInfo = new List<string>();
            foreach (SyndicationItem item in feed.Items)
            {
                string subject = item.Title.Text;
                string summary = item.Summary.Text;
                counter++;
                AvsnittInfo.Add(subject + "|" + summary);
            }
            return AvsnittInfo;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://www.ilikeradio.se/podcasts/hasse-aro/feed";
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                string subject = item.Title.Text;
                string summary = item.Summary.Text;

                //tb.Text += subject + "AAAAAAAAAAAAAAAAAAAAAAA" + summary;
            }
        }

        public static T Deserialize<T>(string url)
        {
            var serializer = new JsonSerializer { TypeNameHandling = TypeNameHandling.All };
            using (var streamReader = new StreamReader(url))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    return serializer.Deserialize<T>(jsonReader);
                }
            }

        }
    }
}
