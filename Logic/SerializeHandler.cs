using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Data;
using Model;

namespace Logic
{
    public class SerializeHandler
    {
        public SerializeHandler()
        {

        }
        public void AddEpisodeToList(string url) {
            List<SyndicationItem> SyndList = Serializer.DeserializeRSS<SyndicationItem>(url);

           
        }
        public void AddKategori()
        {
            List<Kategori> kategorier = new List<Kategori>();
            Serializer.SerializeKategoriToJson(kategorier);
        }
        
        public static void RemoveKategori(string name)
        {
            Serializer.DeleteKategoriLinQ(name);
        }
    }
}
