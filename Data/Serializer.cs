using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using Newtonsoft.Json;
using Model;
using System.Linq;

namespace Data
{
    public class Serializer
    {
        
        public static readonly JsonSerializer _jsonSerializer = new JsonSerializer();

        public Serializer()
        {
           
        }
        public static List<SyndicationItem> DeserializeRSS<T>(string url)
        {
            var AvsnittInfo = new List<SyndicationItem>();
            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();
                

                foreach (SyndicationItem item in feed.Items)
                {
                    AvsnittInfo.Add(item);
                }
                return AvsnittInfo;
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            return AvsnittInfo;
        }

        public static List<Podcast> DeserializePodcastJson()
        {
            var serializer = new JsonSerializer() { TypeNameHandling = TypeNameHandling.All };
            using (var streamReader = new StreamReader("podcasts.json"))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    return serializer.Deserialize<List<Podcast>>(jsonReader);
                }
            }
           
        }
        public static List<Podcast> DeserializePodcastJson(string kategori)
        {
            var serializer = new JsonSerializer() { TypeNameHandling = TypeNameHandling.All };
            using (var streamReader = new StreamReader("podcasts.json"))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    
                    List<Podcast> podcasts = serializer.Deserialize<List<Podcast>>(jsonReader);
                    List<Podcast> sortedPodcasts = new List<Podcast>();
                    foreach(Podcast p in podcasts)
                    {
                        if (p.Kategori == kategori)
                        {
                            
                            sortedPodcasts.Add(p);
                        }
                    }
                    return sortedPodcasts;

                }
            }

        }

        public static bool CheckIfPodcastExsists(string url)
        {
            List<Podcast> podcasts = DeserializePodcastJson();
            foreach(Podcast p in podcasts)
            {
                if (p.Url == url)
                {
                    return true;
                }
            }
            return false;
        }

        public static void DeletePodcastFromJson(string url)
        {
            List<Podcast> podcasts = DeserializePodcastJson();
            var itemToRemove = podcasts.Single(p => p.Url == url);
                podcasts.Remove(itemToRemove);
            SerializeToJson(podcasts);
        }

        public static List<Kategori> DeserializeKategoriJson()
        {
            var serializer = new JsonSerializer() { TypeNameHandling = TypeNameHandling.All };
            using (var streamReader = new StreamReader("kategori.json"))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    return serializer.Deserialize<List<Kategori>>(jsonReader);
                }
            }

        }
        public static void SerializeToJson(List<Podcast> podcasts) {
            using(var sw = new StreamWriter("podcasts.json"))
            {
                using (var jtw = new JsonTextWriter(sw))
                {
                    _jsonSerializer.Serialize(jtw, podcasts);
                }
            }
        }
        public static void SerializeKategoriToJson(List<Kategori> kategori)
        {
            using (var sw = new StreamWriter("kategori.json"))
            {
                using (var jtw = new JsonTextWriter(sw))
                {
                    _jsonSerializer.Serialize(jtw, kategori);
                }
            }
        }

        public static List<Avsnitt> FuckGetLinq(string url)
        {
            List<Podcast> podcasts = DeserializePodcastJson();
            List<Avsnitt> avsnitt = new List<Avsnitt>();
            foreach(Podcast p in podcasts){
                if(p.Url == url)
                {
                    avsnitt = p.ListOfAvsnitt;
                }
            }
            return avsnitt;    
        }
        public static void DeleteKategoriLinQ(string name)
        {
            List<Kategori> kategorier = DeserializeKategoriJson();
            var result = kategorier.
                Where(k => k.Name != name).
                ToList();
            SerializeKategoriToJson(result);
        }

    }
}
