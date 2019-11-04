using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Logic
{
    public class GUIController
    {
        public static List<Avsnitt> GetAvsnittFromSelectedPodcast(string url)
        {
            var a = Serializer.FuckGetLinq(url);
            return a;
            
        }
        public static Avsnitt GetAvsnittFromSelectedPodcast(string url, string title)
        {
            var avsnitt = Serializer.FuckGetLinq(url);
            foreach(Avsnitt a in avsnitt)
            {
                if(a.Title == title)
                {
                    return a;
                }
            }
            return null;
        }
        public static string GetAvsnittBeskrivning(Avsnitt avsnitt)
        {
            return avsnitt.Subject;
        }

        public static List<Podcast> RefreshListView()
        {
            List<Podcast> podcasts = Serializer.DeserializePodcastJson();
            return podcasts;
        }

        public static void SortOnKategori(string kategori)
        {
            Serializer.DeserializePodcastJson(kategori);
        }
    }
}
